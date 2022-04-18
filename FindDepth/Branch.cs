using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDepth
{
    class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        } 
    }

}
