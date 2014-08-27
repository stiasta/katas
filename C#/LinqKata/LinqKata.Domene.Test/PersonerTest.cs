using NUnit.Framework;
using System.Linq;
namespace LinqKata.Domene.Test
{
    /*
     * Oppgaver
     * Lag metoder som returnerer:
     * - Totale summen av formue for alle personer
     * - Totale summen av formue for personer med en gitt nationalitet
     * - Totale summen av formue for personer som har en gitt bokstav i navnet
     * - Totale summen av formue for personer der fornavn starter med en gitt bokstav
     * - Den rikeste personen
     * - Den "fattigste" personen
     * - Den yngste personen
     * - Summen av formue for de to eldste personene
     * - Summen av formue for de personene som ikke er av de to eldste
     * - Gjennomsnittlig alder
     * - Personer sortert på alder fra yngst til eldst
     * - Personer der fornavn eller etternavn innholder angitt substring
     * - Personer gruppert på nationalitet
     * - Personer gruppert på nationalitet deretter sortert på etternavn også sortert på fornavn.
     * - Gjør det samme som den rett over, bare at etternavn og fornavn er sortert i motsatt rekkefølge.
     * - En flat liste med alle "Occupations" (Denne stringen er semicolon separert)
     * - Formue pr. nasjon
     */

    [TestFixture]
    public class PersonerTest
    {
        Personer fPersoner;

        #region Setup & Teardown
        [SetUp]
        public void SetUp()
        {
            fPersoner = new Personer();
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
            // START HER

            
        }
    }
}