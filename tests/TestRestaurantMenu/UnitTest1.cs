using RestaurantMenu;
using System.Diagnostics.Metrics;

namespace TestRestaurantMenu
{
    public class Tests
    {
        [Test]
        [Category("Initialization")]
        [TestCase(null, null)]
        [TestCase(new string[0], null)]
        [TestCase(new string[0], new string[0])]
        public void MenuMaster_ShouldFail_WhenGetInvalidDishesCollections(string[]? commonMenu, string[]? winterMenu)
        {
            Assert.Catch(() => 
            {
                new MenuMaster(commonMenu, winterMenu, 1);
            });
        }

        [Test]
        [Category("Pagination")]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(10)]
        public void MenuMaster_ShouldFail_WhenGetDishesByInvalidPage(int page)
        {
            var menu = CreateMenu(2, 2, 2);
            Assert.Catch(() =>  
            {
                menu.GetDishesOnPage(page);
            });
        }

        [Test]
        [Category("Pagination")]
        [TestCase(5, 5, 5, 2)]
        [TestCase(1, 1, 2, 1)]
        [TestCase(1, 0, 2, 1)]
        [TestCase(1, 0, 20, 1)]
        public void MenuMaster_ShouldPass_WhenGetCorrectPageCount(int commonDishesNumber, int winterDishiesNumber, int dishPerPage, int expectedPages)
        {
            var menu = CreateMenu(commonDishesNumber, winterDishiesNumber, dishPerPage);
            Assert.That(menu.GetPagesNumber(), Is.EqualTo(expectedPages));
        }

        [Test]
        [Category("Dishes")]
        public void MenuMaster_ShouldPass_WhenGetSingleDishesCollection()
        {
            var menu = CreateMenu(3, 3, 1);
            var expected = new[] { "Common1", "Common2", "Common3", "Winter1", "Winter2", "Winter3" };
            CollectionAssert.AreEqual(expected, menu.GetDisies());
        }

        [Test]
        [Category("Pagination")]
        public void MenuMaster_ShouldPass_WhenTryingGetDishesOnPartlyFilledPage()
        {
            var expected = new[] { "Winter3" };

            var menu = CreateMenu(2, 3, 2);
            var actual = menu.GetDishesOnPage(3);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Category("Pagination")]
        [TestCase(3, 4, 3, 3, 1)]
        [TestCase(3, 3, 6, 1, 6)]
        [TestCase(5, 7, 5, 3, 2)]
        public void MenuMaster_ShouldPass_WhenGetCorrectCountOnPage(int commonDishesNumber, int winterDishiesNumber, int dishPerPage, int page, int expectedDishes)
        {
            var menu = CreateMenu(commonDishesNumber, winterDishiesNumber, dishPerPage);
            Assert.That(menu.GetDishesOnPage(page).Count(), Is.EqualTo(expectedDishes));
        }

        [Test]
        [Category("FirstDish")]
        public void MenuMaster_ShouldPass_WhenGetCorrectFirstItemsOnPages()
        {
            var menu = CreateMenu(7, 6, 3);
            var expected = new[] { "Common1", "Common4", "Common7", "Winter3", "Winter6" };
            var actual = menu.GetFirstDisesOnPages();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        [Category("Winter")]
        [TestCase(1, 5, 1, 2)]
        [TestCase(1, 5, 2, 1)]
        [TestCase(11, 1, 3, 4)]
        public void MenuMaster_ShouldPass_WhenGetCorrectFirstWinterMenuPage(int commonDishesNumber, int winterDishiesNumber, int dishPerPage, int expectedPage)
        {
            var menu = CreateMenu(commonDishesNumber, winterDishiesNumber, dishPerPage);
            Assert.That(menu.GetWinterMenuFirstPage(), Is.EqualTo(expectedPage));
        }

        private MenuMaster CreateMenu(int commonMenuDishesNumber, int WinterMenuDishesNumber, int dishiesPerPage)
        {
            var commonMenu = new string[commonMenuDishesNumber];
            var winterMenu = new string[WinterMenuDishesNumber];

            for (var i = 0; i < commonMenuDishesNumber; i++)
                commonMenu[i] = $"Common{i + 1}";

            for (var i = 0; i < WinterMenuDishesNumber; i++)
                winterMenu[i] = $"Winter{i + 1}";

            return new MenuMaster(commonMenu, winterMenu, dishiesPerPage);
        }
    }
}