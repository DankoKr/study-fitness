using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;

namespace TestProject
{
    [TestClass]
    public class TestScheduleAdministration
    {
        [TestMethod]
        public void LoadSchedulesFromDatabaseTest()
        {
			//Arrange
            ScheduleAdministration myManager;
			IScheduleDAL testScheduleDAL = new TestScheduleDAL();
			myManager = new ScheduleAdministration(testScheduleDAL);

            //Act		(currently 2 cardios in fake database)	
            testScheduleDAL.LoadSchedules(myManager);

			//Assert
			Assert.AreEqual(2, myManager.GetSchedules().Count());
		}

        [TestMethod]
        public void CreateScheduleTest()
        {
            //Arrange
            ScheduleAdministration myManager;
            IScheduleDAL testScheduleDAL = new TestScheduleDAL();
            myManager = new ScheduleAdministration(testScheduleDAL);

            //Act			
            Schedule s1 = new Schedule("Title", Convert.ToDateTime("2023-01-12"), "desc", 1);
            Schedule s2 = new Schedule("Title2", Convert.ToDateTime("2023-01-12"), "desc2", 2, "ClientName");
            myManager.AddSchedule(s1);
            myManager.AddSchedule(s2);

            //Assert
            Assert.AreEqual(2, myManager.GetSchedules().Count());
        }

        [TestMethod]
        public void EditScheduleTest()
        {
            //Arrange
            ScheduleAdministration myManager;
            IScheduleDAL testScheduleDAL = new TestScheduleDAL();
            myManager = new ScheduleAdministration(testScheduleDAL);

            //Act			
            Schedule s1 = new Schedule("Title", Convert.ToDateTime("2023-01-12"), "desc", 1);
            myManager.AddSchedule(s1);
            myManager.EditSchedule(s1, 2,"NewTitle", Convert.ToDateTime("2022-02-10"), "newDesc");

            //Assert
            Assert.AreNotEqual("Title", s1.Title);
        }

        [TestMethod]
        public void DeleteScheduleTest()
        {
            //Arrange
            ScheduleAdministration myManager;
            IScheduleDAL testScheduleDAL = new TestScheduleDAL();
            myManager = new ScheduleAdministration(testScheduleDAL);

            //Act			
            Schedule s1 = new Schedule("Title", Convert.ToDateTime("2023-01-12"), "desc", 1);
            myManager.AddSchedule(s1);
            myManager.RemoveSchedule(s1);
            int counter = myManager.GetSchedules().Count(); 
            bool isOne = counter == 1;

            //Assert
            Assert.IsFalse(isOne);
        }
    }
}