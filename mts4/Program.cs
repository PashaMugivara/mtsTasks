using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace mts4
{
    class Program
    {
        //В данной задаче подойдёт сортировка Шелла, но я не совсем понимаю суть задачи
        void ShellSort(int n, List<int> mass)
        {
            int i, j, step;
            int tmp;
            for (step = n / 2; step > 0; step /= 2)
                for (i = step; i < n; i++)
                {
                    tmp = mass[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp < mass[j - step])
                            mass[j] = mass[j - step];
                        else
                            break;
                    }
                    mass[j] = tmp;
                }
        }
    }
}
