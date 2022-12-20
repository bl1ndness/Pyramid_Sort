using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kursach;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TestUnitOriginal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSort()
        {
            Form2 yel = new Form2();
            int[] massiv = new int[] { 6, 3, 5 };
            int[] expected = new int[] { 3, 5, 6 };
            HeapSort sorting = new HeapSort();
            sorting.sort(massiv);
            for(int i = 0; i < massiv.Length; i++)
            {
                Assert.AreEqual(expected[i], massiv[i]);
            }
            
        }
        [TestMethod]
        public void TestAuth()
        {
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "admin";
            string password = "admin";
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void TestRegister()
        {
            User user = new User();
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "admin1";
            string password = "admin1";
            user.login = login;
            user.password = password;
            list.Add(user);
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, true);
        }
        [TestMethod]
        public void TestAuthFalse()
        {
            List<User> list = new List<User>();
            list = Serialize.LoadFromFile("users.txt");
            string login = "admin55";
            string password = "admin55";
            bool good = false;
            foreach (var usr in list)
            {
                if (usr.login == login && usr.password == password)
                {
                    good = true;
                }
            }
            Assert.AreEqual(good, false);
        }
    }
}
