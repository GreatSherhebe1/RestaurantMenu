namespace RestaurantMenu
{
    public class MenuMaster
    {
        private int dishesPerPage;
        private readonly List<string> dishes;
        private int winterMenuStartIndex;

        public MenuMaster(IEnumerable<string> commonMenuDishes, IEnumerable<string> winterMenuDishes, int dishesPerPage)
        {
            var commonMenu = commonMenu?.ToList() ?? new List<string>();
            var winterMenu = winterMenuDishes?.ToList() ?? new List<string>();

            if (commonMenu.Count() + winterMenu.Count() < 1)
                throw new ArgumentException("No dishes defined");

            if (dishesPerPage < 1)
                throw new ArgumentException("Dishes per page can't be less then 1");

            this.dishesPerPage = dishesPerPage;

            dishes = new List<string>();
            dishes.AddRange(commonMenu);
            dishes.AddRange(winterMenu);

            winterMenuStartIndex = winterMenu.Count > 0 ? commonMenu.Count() : -1;
        }

        public int GetWinterMenuFirstPage()
        {
            if (winterMenuStartIndex == -1) return 0;
            return (int)Math.Floor(winterMenuStartIndex / dishesPerPage);
        }

        public int GetDishesNumber() => dishes.Count;

        public int GetPagesNumber() => (int)Math.Ceiling(dishes.Count / dishesPerPage);

        public int GetDishesNumberOnPage(int page)
        {
            var pageDishes = GetPageDishesIndexes(page);
            return pageDishes.end - pageDishes.start;
        }

        public IEnumerable<string> GetDishesOnPage(int page)
        {
            var pageDishes = GetPageDishesIndexes(page);
            return dishes[pageDishes.start..pageDishes.end];
        }

        public IEnumerable<string> GetFirstDisesOnPages()
        {
            for (var i = 0; i < dishes.Count; i+= dishesPerPage)
                yield return dishes[i];
        }

        private (int start, int end) GetPageDishesIndexes(int page)
        {
            if (page < 1 || page > GetPagesNumber())
                throw new ArgumentOutOfRangeException("page is out of menu range");

            var start = (page - 1) * dishesPerPage;
            var end = Math.Min(start + dishesPerPage, dishes.Count);
            return (start, end);
        }
    }
}
