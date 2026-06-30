namespace RestaurantMenu
{
    public class MenuMaster
    {
        private int dishesPerPage;
        private readonly List<string> dishes;
        private int winterStartIndex;

        public MenuMaster(IEnumerable<string> commonMenuDishes, IEnumerable<string> winterMenuDishes, int dishesPerPage)
        {
            var commonMenu = commonMenu?.ToList() ?? new List<string>();
            var winterMenu = winterMenuDishes?.ToList() ?? new List<string>();

            if (commonMenu.Count() + winterMenu.Count() < 1)
                throw new ArgumentException("No dishes defined");

            if (dishesPerPage < 1)
                throw new ArgumentException("Dishes per page can't be less then 1");

            dishes = new List<string>();
            dishes.AddRange(commonMenu);
            dishes.AddRange(winterMenu);

            if (winterMenu.Count > 0)
            {
                var commonMenuLastPage = (int)Math.Ceiling(commonMenu.Count / dishesPerPage);
                var commonMenuModulo = commonMenu.Count % dishesPerPage;
                winterStartIndex = commonMenuModulo == 0 ? commonMenuLastPage + 1 : commonMenuLastPage;
            }
            else
                winterStartIndex = -1;
        }

        public int GetWinterMenuFirstPage() => winterStartIndex;

        public int GetDishesNumber();

        public int GetPagesNumber();

        public int GetDishesNumberOnPage(int page);

        public IEnumerable<string> GetDishesOnPage(int page);

        public IEnumerable<string> GetFirstDisesOnPages();
    }
}
