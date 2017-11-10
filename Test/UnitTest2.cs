using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;

namespace Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;
    using Morgengry;

    namespace Test
    {
        [TestClass]
        public class UnitTestFile01
        {
            Book b1, b2, b3;
            Amulet a1, a2, a3;
            Course c1, c2;
            ValuableRepository vr1, vr2;

            [TestInitialize]
            public void Init()
            {
                b1 = new Book("No. B1");
                b2 = new Book("No. B2", "Falling in Love with Yourself");
                b3 = new Book("No. B3", "Spirits in the Night", 123.55);
                a1 = new Amulet("No. A1");
                a2 = new Amulet("No. A2", Level.high);
                a3 = new Amulet("No. A3", Level.low, "Modern");
                c1 = new Course("Basis kursus");
                c2 = new Course("Kursus 2", 128);

                vr1 = new ValuableRepository();
                vr1.AddValuable(b1);
                vr1.AddValuable(a1);
                vr1.AddValuable(b2);
                vr1.AddValuable(a3);
                vr1.AddValuable(c1);
                vr1.AddValuable(b3);
                vr1.AddValuable(a2);
                vr1.AddValuable(c2);

                vr2 = new ValuableRepository();

                if (File.Exists("ValuableRepository.txt"))
                {
                    File.Delete("ValuableRepository.txt");
                }
                if (File.Exists("TestFile01.txt"))
                {
                    File.Delete("TestFile01.txt");
                }
                if (File.Exists("TestFile02.txt"))
                {
                    File.Delete("TestFile02.txt");
                }
            }

            [TestMethod]
            public void TestSave()
            {
                vr1.Save("TestFile01.txt");
                Assert.AreEqual(File.Exists("TestFile01.txt"), true);
            }

            [TestMethod]
            public void TestLoadWithFileName()
            {
                vr1.Save("TestFile01.txt");
                vr2.Load("TestFile01.txt");
                int noOfElements = vr1.Count();
                Assert.AreEqual(noOfElements, vr2.Count());
                Assert.AreEqual(vr1.GetValuable("No. B2").ToString(), vr2.GetValuable("No. B2").ToString());
                Assert.AreEqual(vr1.GetValuable("No. B1").ToString(), vr2.GetValuable("No. B1").ToString());
                Assert.AreEqual(vr1.GetValuable("No. B3").ToString(), vr2.GetValuable("No. B3").ToString());

                Assert.AreEqual(vr1.GetValuable("Basis kursus").ToString(),
                 vr2.GetValuable("Basis kursus").ToString());
                Assert.AreEqual(vr1.GetValuable("Kursus 2").ToString(), vr2.GetValuable("Kursus 2").ToString());

                Assert.AreEqual(vr1.GetValuable("No. A3").ToString(), vr2.GetValuable("No. A3").ToString());
                Assert.AreEqual(vr1.GetValuable("No. A1").ToString(), vr2.GetValuable("No. A1").ToString());
                Assert.AreEqual(vr1.GetValuable("No. A2").ToString(), vr2.GetValuable("No. A2").ToString());
            }


            [TestMethod]
            public void TestLoadWithDefaultFile()
            {
                vr1.Save();
                vr2.Load();
                int noOfElements = vr1.Count();
                Assert.AreEqual(noOfElements, vr2.Count());
                Assert.AreEqual(vr1.GetValuable("No. B2").ToString(), vr2.GetValuable("No. B2").ToString());
                Assert.AreEqual(vr1.GetValuable("No. B1").ToString(), vr2.GetValuable("No. B1").ToString());
                Assert.AreEqual(vr1.GetValuable("No. B3").ToString(),
                 vr2.GetValuable("No. B3").ToString());

                Assert.AreEqual(vr1.GetValuable("Basis kursus").ToString(),
                 vr2.GetValuable("Basis kursus").ToString());
                Assert.AreEqual(vr1.GetValuable("Kursus 2").ToString(), vr2.GetValuable("Kursus 2").ToString());

                Assert.AreEqual(vr1.GetValuable("No. A3").ToString(), vr2.GetValuable("No. A3").ToString());
                Assert.AreEqual(vr1.GetValuable("No. A1").ToString(), vr2.GetValuable("No. A1").ToString());
                Assert.AreEqual(vr1.GetValuable("No. A2").ToString(), vr2.GetValuable("No. A2").ToString());
            }
        }
    }

    //[TestClass]
    //public class UnitTest2
    //{
    //    Book b1, b2, b3;
    //    Amulet a11, a12, a13;
    //    Course c111, c112;
    //    CourseRepository courses = new CourseRepository();
    //    BookRepository books = new BookRepository();
    //    AmuletRepository amulets = new AmuletRepository();

    //    [TestInitialize]
    //    public void Init()
    //    {
    //        Utility.LowQualityValue = 12.5;
    //        Utility.MediumQualityValue = 20.0;
    //        Utility.HighQuality = 27.5;

    //        b1 = new Book("1");
    //        b2 = new Book("2", "Falling in Love with Yourself");
    //        b3 = new Book("3", "Spirits in the Night", 123.55);
    //        books.AddBook(b1);
    //        books.AddBook(b2);
    //        books.AddBook(b3);

    //        a11 = new Amulet("11");
    //        a12 = new Amulet("12", Level.high);
    //        a13 = new Amulet("13", Level.low, "Capricorn");
    //        amulets.AddAmulet(a11);
    //        amulets.AddAmulet(a12);
    //        amulets.AddAmulet(a13);

    //        c111 = new Course("Eufori med røg");
    //        c112 = new Course("Nuru Massage using Chia Oil", 157);
    //        courses.AddCourse(c111);
    //        courses.AddCourse(c112);
    //    }

    //    [TestMethod]
    //    public void TestGetValueForBook()
    //    {
    //        Assert.AreEqual(Utility.GetValueOfBook(b1), 0.0);
    //        Assert.AreEqual(Utility.GetValueOfBook(b2), 0.0);
    //        Assert.AreEqual(Utility.GetValueOfBook(b3), 123.55);
    //        Assert.AreEqual(books.GetTotalValue(), 123.55);
    //    }

    //    [TestMethod]
    //    public void TestGetValueForAmulet()
    //    {
    //        Assert.AreEqual(Utility.GetValueOfAmulet(a11), 20.0);
    //        Assert.AreEqual(Utility.GetValueOfAmulet(a12), 27.5);
    //        Assert.AreEqual(Utility.GetValueOfAmulet(a13), 12.5);
    //        Assert.AreEqual(amulets.GetTotalValue(), 60.0);
    //    }

    //    [TestMethod]
    //    public void TestGetValueForCourse()
    //    {
    //        Assert.AreEqual(Utility.GetValueOfCourse(c111), 0.0);
    //        Assert.AreEqual(Utility.GetValueOfCourse(c112), 1750.0);
    //        Assert.AreEqual(courses.GetTotalValue(), 1750.0);
    //    }
    //}
}
