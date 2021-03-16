using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to add the method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA -> Arrange, Act, Assert

            //Arrange-> overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act -> Get/ run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert --> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);

            Console.WriteLine(addResult);
        }


        //Testing the read method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA Rules Apply...

            //Arrange -> initial setup
            //creating the content
            StreamingContent content = new StreamingContent();

            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //Adding to the repo(content)
            repo.AddContentToDirectory(content);

            //Act
            //our plan is to store the list of streaming content w/n a variable
            List<StreamingContent> contents = repo.GetContent();

            //looks through our entire list and returns true if there is content
            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //This is the arrange part...
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            //we make a new movie here...finally...
            _content = new StreamingContent("Rubber", "A car tire come to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 5.8d);

            _repo.AddContentToDirectory(_content);


        }

        //retrive content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange ...Already done above

            //Act 
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            StreamingContent theFailure = _repo.GetContentByTitle("Rubber-Duck");

            //Assert
            Assert.AreEqual(_content, searchResult);

        }

        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire come to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 5.8d);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
            //Console.WriteLine(GiveMeInfo(_content));
        }

        //public string GiveMeInfo(StreamingContent content)
        //{
        //   var result = $"[content.Title]/n" +
        //              $"[content.StarRating]"'
        //    return result;
        //}

        //Test the Delete Method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act We are removing the movie here.....
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);

        }

    }
}
