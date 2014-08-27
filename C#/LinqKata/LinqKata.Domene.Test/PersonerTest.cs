using NUnit.Framework;
using System.Linq;
namespace LinqKata.Domain.Test
{
    /*
     * This kata has a data set you can work against that is retrieved in the fPerson object in the test.
     * Use this dataset and do not focus on mocking out the data. The point of this kata is to train on Linq
     * Tasks
     * Create methods that returns:
     * - Sum of fortune for all persons
     * - Sum of fortune for persons with given nationality
     * - Sum of fortune for persons with a gived letter in the name
     * - Sum of fortune for persons where first name starts with given letter
     * - The richest person
     * - The "poorest" person
     * - Then youngest person (Add datetime parsing method to the person object)
     * - Fortune of the two oldest persons
     * - Fortune of the persons that is not amongst the two oldest
     * - Average age
     * - Persons sorted on age from youngest to oldest
     * - Persons where first name or last name contains given substring
     * - Persons grouped by nationality
     * - Persons grouped by nationality, and then sorted by last name and further sorted by first name
     * - Same as above, but reversed sorting
     * - A flattened list with all the occupations for all persons
     * - Fortune pr nation
     */

    [TestFixture]
    public class PersonListTest
    {
        PersonList fPersoner;

        #region Setup & Teardown
        [SetUp]
        public void SetUp()
        {
            fPersoner = new PersonList();
        }

        [TearDown]
        public void TearDown()
        {
            if (fPersoner != null)
            {
                fPersoner = null;
            }
        }
        #endregion

        [Test]
        public void Foo()
        {
            // START HERE

            
        }
    }
}