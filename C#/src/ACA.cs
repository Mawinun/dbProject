using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_project_Admin_Interface
{
    class ACA
    {
        List<Tuple<int, int>> relations;    // Left = AHid, Right = Aid

        public ACA()
        {
            relations = new List<Tuple<int,int>>();
        }

        public void addRelation(int AHid, int Aid)
        {
            Tuple<int,int> temp = new Tuple<int,int>(AHid,Aid);
            relations.Add(temp);
        }

        public List<int> findRelatedAccounts(int AHid)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < relations.Count; i++)
            {
                if (relations[i].Item1.Equals(AHid))
                    temp.Add(relations[i].Item2); 
            }
            return temp;
        }

        public List<int> findRelatedAccountHolders(int Aid)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < relations.Count; i++)
            {
                if (relations[i].Item2.Equals(Aid))
                    temp.Add(relations[i].Item1);
            }
            return temp;
        }

        public int getNrOfACAs()
        {
            return relations.Count;
        }

        public bool alreadyExists(int AHid, int Aid)
        {
            bool result = false;
            for (int i = 0; i < relations.Count && !result; i++)
            {
                if (relations[i].Item1.Equals(AHid) && relations[i].Item2.Equals(Aid))
                    result = true;
            }
            return result;
        }

        public int commonAccountHolder(int AidOne, int AidTwo)
        {
            int result = -1;
            bool found = false;
            List<int> ahsOne = findRelatedAccountHolders(AidOne);
            List<int> ahsTwo = findRelatedAccountHolders(AidTwo);
            for (int i = 0; i < ahsOne.Count && !found; i++)
            {
                for(int j=0;j<ahsTwo.Count && !found;j++)
                {
                    if (ahsOne[i].Equals(ahsTwo[j]))
                    {
                        result = ahsOne[i];
                        found = true;
                    }
                }
            }
            return result;
        }
    }
}
