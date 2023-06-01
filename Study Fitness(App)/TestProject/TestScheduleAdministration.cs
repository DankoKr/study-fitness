using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using ClassLibrary.TestDataClasses;
using ClassLibrary.UserClasses;

namespace TestProject
{
    [TestClass]
    public class TestScheduleAdministration
    {
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows = true;

        [TestMethod]
        public void LoadSchedulesFromDatabaseTest()
        {
			//Arrange
            ScheduleAdministration myManager;
			IScheduleDAL testScheduleDAL = new TestScheduleDAL();
			myManager = new ScheduleAdministration(testScheduleDAL);

            //Act		(currently 2 schedules in fake database)	
            testScheduleDAL.LoadSchedules(myManager, currentPage, pageSize, hasRows);

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
            myManager.EditSchedule(s1, 2, Convert.ToDateTime("2022-02-10"), "newDesc");

            //Assert
            Assert.AreNotEqual("2022-02-10", s1.Date);
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

        [TestMethod]
        public void AssignScheduleTest()
        {
            //Arrange
            ScheduleAdministration myManager;
            IScheduleDAL testScheduleDAL = new TestScheduleDAL();
            myManager = new ScheduleAdministration(testScheduleDAL);
            Schedule s1 = new Schedule("Title", Convert.ToDateTime("2023-01-12"), "desc", 1);
            User u = new User("John","johny", "1234", "Member");

            //Act			
            myManager.AddSchedule(s1);
            myManager.AssignSchedule(s1,u.FirstName,"Schedule Title");


            //Assert
            Assert.IsNotNull(s1.ClientName);
        }

        [TestMethod]
        public void UnAssignScheduleTest()
        {
            //Arrange
            ScheduleAdministration myManager;
            IScheduleDAL testScheduleDAL = new TestScheduleDAL();
            myManager = new ScheduleAdministration(testScheduleDAL);
            Schedule s1 = new Schedule("Title", Convert.ToDateTime("2023-01-12"), "desc", 1);
            User u = new User("John", "johny", "1234", "Member");

            //Act			
            myManager.AddSchedule(s1);
            myManager.AssignSchedule(s1, u.FirstName, "Schedule Title");
            myManager.UnAssignSchedule(s1);


            //Assert
            Assert.IsNull(s1.ClientName);
        }
    }
}