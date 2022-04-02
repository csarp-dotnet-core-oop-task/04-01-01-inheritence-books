using Microsoft.VisualStudio.TestTools.UnitTesting;
using Konyvek.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konyvek.model.Tests
{
    [TestClass()]
    public class PaperBookTests
    {
        [TestMethod()]
        public void PaperBookTestQuantity()
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            k1.Sell(50);

            int expected = 50;
            int actual = k1.Quantity;

            Assert.AreEqual(expected, actual, "Könyv eladása után a mennyisége nem megfelelő!");
        }

        [TestMethod()]
        public void PaperBookTestNegativBuy()
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            k1.Sell(50);
            try
            {
                k1.Buy(-10);
            }
            catch (QuantityIsZeroException e)
            {
                return;
            }
            catch(Exception e)
            {
                Assert.Fail("Negatív mennyiségű könyv vásárlás után a metódus nem a megfelelő kivételt dobja!");
            }
            Assert.Fail("Negatív mennyiségű könyv vásárlás után a metódus nem dob kivételt!");
        }

        [TestMethod()]
        public void PaperBookTestNegativSell()
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            k1.Sell(50);
            try
            {
                k1.Sell(-10);
            }
            catch (QuantityIsZeroException e)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Negatív mennyiség könyv eladása után a metódus nem a megfelelő kivételt dobja!");
            }
            Assert.Fail("Negatív mennyiségű könyv eladása után a metódus nem dob kivételt!");
        }

        [TestMethod()]
        public void PaperBookTestToMuchSell()
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            k1.Sell(50);
            try
            {
                k1.Sell(100);
            }
            catch (QuantitySoldLargerExistingQuantityException e)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Túl sok könyv eladása után a metódus nem a megfelelő kivételt dobja!");
            }
            Assert.Fail("Túl sok könyv eladása után a metódus nem dob kivételt!");
        }

        [TestMethod()]
        public void PaperBookToString()
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            k1.Sell(50);

            string expectedToString = "Könyv szerzője: Andrew Troelsen\nKönyv címe: Pro C# 7\nKönyv oldalszáma: 155\nKönyv készlet: 50 db.";
            string actualToString = k1.ToString();
            int actualCompareTo = expectedToString.CompareTo(actualToString);
            int expectedComaperTo = 0;
        }
    }
}