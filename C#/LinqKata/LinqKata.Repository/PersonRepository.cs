using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKata.Domene.Repository
{
    public class PersonRepository
    {
        #region hidden >.>
        private const string kJson = @"[
  {
    'Name': 'Warren Buffett',
    'DOB': 'August 30, 1930',
    'Nationality': 'American',
    'Religion': 'Warren Edward Buffett',
    'Children': 3,
    'Business': 'Investment',
    'Fortune': 39.0,
    'Occupation': 'Chairman & CEO of Berkshire Hathaway',
    'ExtraTitle': 'Career'
  },
  {
    'Name': 'Bill Gates',
    'DOB': 'October 28, 1955',
    'Nationality': 'American',
    'Religion': 'Agnostic',
    'Children': 3,
    'Business': 'Software',
    'Fortune': 59.0,
    'Occupation': 'Chairman of Microsoft;Chairman of Corbis;Co-Chair of the Bill & Melinda Gates Foundation;Director of Berkshire Hathaway;CEO of Cascade Investment',
    'ExtraTitle': 'Philantrophy'
  },
  {
    'Name': 'Bernard Arnault',
    'DOB': '5 March 1949',
    'Nationality': 'French',
    'Religion': null,
    'Children': 0,
    'Business': null,
    'Fortune': 41.0,
    'Occupation': 'Chairman & CEO;LVMH Chairman;Christian Dior SA',
    'ExtraTitle': null
  },
  {
    'Name': 'Larry Ellison',
    'DOB': 'August 17, 1944',
    'Nationality': 'American',
    'Religion': 'Jewish',
    'Children': 2,
    'Business': 'Software',
    'Fortune': 33.0,
    'Occupation': 'CEO of Oracle Corporation',
    'ExtraTitle': null
  },
  {
    'Name': 'Lakshmi Mittal',
    'DOB': '15 June 1950',
    'Nationality': 'Indian',
    'Religion': 'Hinduism',
    'Children': 2,
    'Business': 'Steel',
    'Fortune': 31.0,
    'Occupation': 'Chairman & CEO of ArcelorMittal;Director of Goldman Sachs;Owner of Karrick Limited;Co-owner of Queens Park Rangers F.C.',
    'ExtraTitle': null
  },
  {
    'Name': 'Mark Zuckerberg',
    'DOB': 'May 14, 1984',
    'Nationality': 'American',
    'Religion': 'Jewish',
    'Children': 0,
    'Business': 'Facebook',
    'Fortune': 17.0,
    'Occupation': 'CEO/President of Facebook',
    'ExtraTitle': 'Software Developer'
  }
]";
        #endregion

        public Personer Alle()
        {
            return JsonConvert.DeserializeObject<Personer>(kJson);
        }
    }
}
