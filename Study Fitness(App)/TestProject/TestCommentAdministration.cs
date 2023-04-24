using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;

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
            testCommentDAL.LoadComments(myManager);

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
            myManager.AddComment(new Comment("Test", "desc", 5), 0);

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
            myManager.EditComment(c, "NewTitle", "NewDescription", 3);


            //Assert
            Assert.AreNotEqual(c.Title, "Test");
        }

        [TestMethod]
        public void DeleteCommentTest()
        {
            //Arrange    (currently 2 comments in fake database)
            CommentAdministration myManager;
            ICommentDAL testCommentDAL = new TestCommentDAL();
            myManager = new CommentAdministration(testCommentDAL);
            testCommentDAL.LoadComments(myManager);

            //Act		
            Comment selectedComment = myManager.GetComment("Com1");
            myManager.RemoveComment(selectedComment);

            //Assert
            Assert.AreEqual(1, myManager.GetComments().Count());
        }
    }
}