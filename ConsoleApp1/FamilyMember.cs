using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks
{

    /*Спроектируйте программу для построения генеалогического дерева.
     * Учтите что у нас есть члены семьи у кого нет детей(дет). 
     * Есть члены семьи у кого дети есть (взрослые). Есть мужчины и женщины.
     */
    public class FamilyMember
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Spouse { get; set; }
        public FamilyMember[] GetGrandmothers()
        {
            return new FamilyMember[] { Mother.Mother, Father.Mother };
        }
        public FamilyMember[] GetGrandfathers()
        {
            return new FamilyMember[] { Mother.Father, Father.Father };
        }
    }

    public enum Gender { man, woman }
}

