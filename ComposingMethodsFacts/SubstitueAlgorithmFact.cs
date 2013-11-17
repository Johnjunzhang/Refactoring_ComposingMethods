using Composing_Methods;
using Xunit;

namespace ComposingMethodsFacts
{
    public class SubstitueAlgorithmFact
    {
        [Fact]
        public void should_find_don_given_there_is_don_in_people_list()
        {
            var peopleList = new []{"Don", "Done", "Do"};
            var substitueAlgorithm = new SubstitueAlgorithm();
            Assert.Equal("Don", substitueAlgorithm.FoundPerson(peopleList));
        }

       [Fact]
        public void should_find_john_given_there_is_john_in_people_list()
        {
            var peopleList = new []{"John", "Joh", "Jo"};
            var substitueAlgorithm = new SubstitueAlgorithm();
            Assert.Equal("John", substitueAlgorithm.FoundPerson(peopleList));
        }

       [Fact]
        public void should_find_kent_given_there_is_kent_in_people_list()
        {
            var peopleList = new []{"Kent", "Ken", "Ke"};
            var substitueAlgorithm = new SubstitueAlgorithm();
            Assert.Equal("Kent", substitueAlgorithm.FoundPerson(peopleList));
        }

        [Fact]
        public void should_not_find_people_given_there_is_no_matched_name_in_people_list()
        {
            var peopleList = new []{"Done", "Do"};
            var substitueAlgorithm = new SubstitueAlgorithm();
            Assert.Equal(string.Empty, substitueAlgorithm.FoundPerson(peopleList));
        }
    }
}