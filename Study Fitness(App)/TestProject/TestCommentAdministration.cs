using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.TestDataClasses;

namespace TestProject
{
    [TestClass]
    public class TestCommentAdministration
    {
        [TestMethod]
        public void LoadCommentsFromDatabaseTest()
        {
			//Arrange
            CommentAdministration myManager;
			ICommentDAL testCommentDAL = new TestCommentDAL();
			myManager = new CommentAdministration(testCommentDAL);

            //Act		(currently 2 comments in fake database)	
            testCommentDAL.LoadComments(myManager, 1, 20, true);

			//Assert
			Assert.AreEqual(2, myManager.GetComments().Count());
		}

        [TestMethod]
        public void AddCommentTest()
        {
            //Arrange
            CommentAdministration myManager;
            ICommentDAL testCommentDAL = new TestCommentDAL();
            myManager = new CommentAdministration(testCommentDAL);

            //Act		
            myManager.AddCommentExercise(new Comment("Test", "desc", 5), 1, 1);

            //Assert
            Assert.AreEqual(1, myManager.GetComments().Count());
        }

        [TestMethod]
        public void EditCommentTest()
        {
            //Arrange
            CommentAdministration myManager;
            ICommentDAL testCommentDAL = new TestCommentDAL();
            myManager = new CommentAdministration(testCommentDAL);
            Comment c = new Comment("Test", "desc", 5);

            //Act		
            myManager.EditComment(c, "NewDescription", 3);


            //Assert
            Assert.AreNotEqual(c.Description, "desc");
        }

        [TestMethod]
        public void DeleteCommentTest()
        {
            //Arrange    (currently 2 comments in fake database)
            CommentAdministration myManager;
            ICommentDAL testCommentDAL = new TestCommentDAL();
            myManager = new CommentAdministration(testCommentDAL);
            testCommentDAL.LoadComments(myManager, 1, 20, true);

            //Act		
            Comment selectedComment = myManager.GetComment("Com1");
            myManager.RemoveComment(selectedComment);

            //Assert
            Assert.AreEqual(1, myManager.GetComments().Count());
        }
    }
}