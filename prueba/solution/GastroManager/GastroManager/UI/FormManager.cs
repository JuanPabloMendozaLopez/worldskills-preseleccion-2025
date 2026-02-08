using GastroManager.Data;
using GastroManager.DTOs;
using GastroManager.Interfaces;
using GastroManager.Logic;
using GastroManager.UserControls;
using System.Text;

namespace GastroManager
{
    public partial class FormManager : Form
    {

        private bool _IsLoading = false;

        //Repos
        private readonly DishesLogic _dishesLogic;
        private readonly CategoriesLogic _categoriesLogic;
        private readonly RecipeLogic _recipeLogic;
        private readonly IngredientsLogic _ingredientsLogic;

        public FormManager()
        {

            InitializeComponent();
            this.MaximizeBox = false;

            //Set colors
            pItems.BackColor = ColorTranslator.FromHtml("#F96436");

            //Init repos
            var repoDishes = new DishesData();
            var repoIngredients = new IngredientsData();
            _dishesLogic = new DishesLogic(repoDishes, repoIngredients);

            var repoCategories = new CategoriesData();
            _categoriesLogic = new CategoriesLogic(repoCategories);

            var repoRecipe = new RecipeData();
            _recipeLogic = new RecipeLogic(repoRecipe);

            var repoIngredient = new IngredientsData();
            _ingredientsLogic = new IngredientsLogic(repoIngredient);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            tabControls.SelectedTab = tabIngredients;
            this.Text = "Ingredients";
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            tabControls.SelectedTab = tabDishes;
            this.Text = "Dishes";
        }

        private void AdjustPrices()
        {

            numMax.Minimum = numMin.Value;
            numMin.Maximum = numMax.Value;

        }

        private void LoadCategories()
        {
            //Refresh items
            cbCategory.Items.Clear();

            //Obtain all categories
            var categories = _categoriesLogic.GetCategories();

            //Add categories to the combobox
            cbCategory.Items.Add("All categories");
            cbCategory.Items.AddRange(categories.Select(u => u.CategoryName).ToArray());
            cbCategory.SelectedIndex = 0;

        }

        private void ExecuteFilter()
        {

            if (_IsLoading) return;

            //Clear all dishes of the DataGridView
            dgvDishes.Rows.Clear();

            //Set filters
            string category = cbCategory.Text;
            string name = txtName.Text;
            bool availableIngredients = checkAvailable.Checked;
            int min = Convert.ToInt32(numMin.Value);
            int max = Convert.ToInt32(numMax.Value);

            var dishes = _dishesLogic.GetFilteredDishes(categoryName: category,
                                                       dishName: name,
                                                       availableIngredients:
                                                       availableIngredients,
                                                       minPrice: min,
                                                       maxPrice: max);

            //Add dishes to the DataGridView
            foreach (var dish in dishes)
            {

                dgvDishes.Rows.Add(dish.DishId, dish.DishName, dish.FinalPriceForClients, "View");

            }

        }

        private void LoadAllDishes()
        {

            //Clear all dishes of the DataGridView
            dgvDishes.Rows.Clear();

            //Obtain all dishes
            var dishes = _dishesLogic.GetDishes();

            //Add dishes to the DataGridView
            foreach (var dish in dishes)
            {

                dgvDishes.Rows.Add(dish.DishId, dish.DishName, dish.FinalPriceForClients, "View");

            }

        }

        private void LoadAllIngredients()
        {

            flowIngredients.Controls.Clear();

            var ingredients = _ingredientsLogic.GetIngredients();

            foreach (var item in ingredients)
            {

                var ingredientControl = new IngredientControl()
                {

                    IngredientName = item.IngredientName,
                    Price = item.PricePerUnit,
                    Stock = item.AvailableCountInStock,
                    Unit = item.MainUnit,
                    IngredientId = item.IngredientId,
                    
                };

                ingredientControl.DeleteAction += DeleteAction;
                ingredientControl.ChangedStockAction += ChangedStockAction;

                flowIngredients.Controls.Add(ingredientControl);

                
            }

        }

        private void RefreshInventoryPrice()
        {

            //Calculate the total price of the inventory
            decimal totalOfIngredients = 0;

            foreach (var item in flowIngredients.Controls)
            {

                var ingredientControl = (IngredientControl)item;

                totalOfIngredients += ingredientControl.Price * ingredientControl.Stock;

                
            }

            lblIngredientsDescription.Text = $"Total available ingredients for the amount ($): {totalOfIngredients}";

        }

        private void DeleteAction(object? sender, int id)
        {

            var dialog = MessageBox.Show("Do you want eliminate this ingredient from the inventory?", "Confirm", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                var success = _ingredientsLogic.Delete(id);

                MessageBox.Show(success);

            }

            RefreshInventoryPrice();

        }

        private void ChangedStockAction(object? sender, int id)
        {

            var control = (IngredientControl)sender!;
            var stock = Convert.ToInt32(control?.Stock);

            _ingredientsLogic.ChangeStock(id, stock);

            RefreshInventoryPrice();


        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            //Loading state: If isn't complete the others events can't succeed
            _IsLoading = true;

            //Adjust numericupdowns for the minimun and maximun prices
            AdjustPrices();

            //Load all items
            LoadCategories();
            LoadAllDishes();
            LoadAllIngredients();
            RefreshInventoryPrice();



            _IsLoading = false;

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }

        private void checkAvailable_CheckedChanged(object sender, EventArgs e)
        {
            ExecuteFilter();
        }
        private void minPrice_ValueChanged(object sender, EventArgs e)
        {
            AdjustPrices();
            ExecuteFilter();
        }

        private void maxPrice_ValueChanged(object sender, EventArgs e)
        {

            AdjustPrices();
            ExecuteFilter();

        }

        private void dgvDishes_SelectionChanged(object sender, EventArgs e)
        {
            dgvDishes.ClearSelection();
        }

        private void dgvDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDishes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "View")
            {

                int dishId = Convert.ToInt32(dgvDishes.Rows[e.RowIndex].Cells[0].Value);

                //Save the Id of the dish in the Image
                pImageDetail.Tag = dishId;

                LoadDishDetails(dishId);

                tabControls.SelectedTab = tabDishDescription;
                this.Text = "Recipes";

            }
        }

        private void LoadDishDetails(int Id)
        {

            var dish = _dishesLogic.GetDish(Id);

            if (dish == null)
            {
                MessageBox.Show("The dish selected don't exists");
                return;
            }

            //Put info in their respective labels
            lblRecipeDetail.Text = @$"Recipe for ""{dish.DishName}""";
            lblCategoryDetail.Text = $"Category: {dish.CategoryName}";
            lblTimeDetail.Text = $"Cooking Time: {dish.Time} minutes";
            numServingDetail.Value = dish.BaseServings;
            lblCostDetail.Text = $"Total Cost: {dish.FinalPriceForClients * dish.BaseServings}$";
            lblCostDetail.Tag = dish.FinalPriceForClients;
            txtDescriptionDetail.Text = $"Short Description: {dish.Description}";


            var formattedIngredients = new List<IngredientReadDTO>();

            //If there are identical ingredients, they are added together.
            foreach (var item in dish.Ingredients)
            {

                if (!formattedIngredients.Any(u => u.IngredientName == item.IngredientName))
                {
                    formattedIngredients.Add(item);
                }
                else
                {

                    var ingredient = formattedIngredients.FirstOrDefault(u => u.IngredientName == item.IngredientName);

                    ingredient.PricePerUnit += item.PricePerUnit;
                    ingredient.Quantity += item.Quantity;

                }

            }

            //Fill the DataGridView with the ingredients of the dish
            foreach (var item in formattedIngredients)
            {

                dgvIngredientsDetail.Rows.Add(item.AvailableCountInStock > 0, item.IngredientName, item.Quantity, item.MainUnit, item.PricePerUnit);

            }


            //Dispose resources
            if (pImageDetail.Image != null)
            {
                pImageDetail.Image.Dispose();
            }

            //Load image of the Dish
            pImageDetail.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Source", dish.ImagePath));

        }

        private void pImageDetail_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(pImageDetail.Tag);

            var recipes = _recipeLogic.GetRecipeOfDish(id);

            string recipeContent = "";

            for (int i = 0; i < recipes.Count; i++)
            {

                recipeContent += $"{i + 1}. {recipes[i]}\n";

            }

            MessageBox.Show(recipeContent, lblRecipeDetail.Text);

        }

        private void btnBackDetail_Click(object sender, EventArgs e)
        {

            tabControls.SelectedTab = tabDishes;
            this.Text = "Dishes";

        }

        private void numServingDetail_ValueChanged(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(pImageDetail.Tag);
            decimal price = Convert.ToDecimal(lblCostDetail.Tag);

            int baseServings = Convert.ToInt32(numServingDetail.Value);

            _dishesLogic.ChangeServings(id, baseServings);

            lblCostDetail.Text = $"Total Cost: {price * baseServings}$";

        }

    }
}
