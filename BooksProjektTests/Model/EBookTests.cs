using Microsoft.VisualStudio.TestTools.UnitTesting;
using Konyvek.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Konyvek.model.Tests
{
    [TestClass()]
    public class EBookTests
    {
        [TestMethod()]
        public void EBookTestDownloadNumber()
        {
            EBook ek = new EBook("Reiter István", "C# programozás lépésről lépésre", 340);
            ek.Download();
            ek.Download();
            ek.Download();

            int expected = 3;
            int actual = ek.DownloadNumber;

            Assert.AreEqual(expected, actual, "A letöltésszám három letöltés esetén nem megfelelő!");
        }

        [TestMethod()]
        public void EBookTestToString()
        {
            EBook ek = new EBook("Reiter István", "C# programozás lépésről lépésre", 340);
            ek.Download();
            ek.Download();
            ek.Download();
            ek.Download();
            ek.Download();
            ek.Download();
            string expectedToString = "Könyv szerzője: Reiter István\nKönyv címe: C# programozás lépésről lépésre\nKönyv oldalszáma: 340\nKönyv letöltésszáma: 6 db.";
            string actualToString = ek.ToString();
            int actualCompareTo = expectedToString.CompareTo(actualToString);
            int expectedComaperTo = 0;

            Assert.AreEqual(expectedComaperTo, actualCompareTo, "Az EBookTest ToString metódusa nem a megfelelő üzenetet adja!");
        }
    }
}