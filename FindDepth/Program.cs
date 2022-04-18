using System;

namespace FindDepth
{
    class Program
    {
        static int FindMaxBranch(Branch branches, int level)
        {
            int max = level;

            foreach (var branche in branches.branches)
            {
                int current = FindMaxBranch(branche,level+1);
                if (max < current)
                    max = current;
            }

            return max;
        }

        static void Main(string[] args)
        {
            int index;
            Branch root = new Branch();

            Branch left_x = new Branch();
            Branch left_y = new Branch();

            left_y.AddBranch(left_x);
            root.AddBranch(left_y);

            Branch middle_x = new Branch();

            Branch middle_y = new Branch();
            Branch middle_z = new Branch();

            middle_y.AddBranch(middle_z);

            middle_x.AddBranch(middle_y);

            root.AddBranch(middle_x);

            Branch right_y = new Branch();
            Branch middle_y2 = new Branch();
            Branch left_z = new Branch();
            Branch right_z = new Branch();

            middle_x.AddBranch(right_y);
            middle_x.AddBranch(middle_y2);
            middle_y2.AddBranch(left_z);
            middle_y2.AddBranch(right_z);

            Branch middle_e = new Branch();

            left_z.AddBranch(middle_e);

            index = FindMaxBranch(root, 1);

            Console.WriteLine($"Max : {index}");

        }
    }
}
