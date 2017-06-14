using System.Collections.Generic;

namespace SkillTreeHomeWork
{
    public interface ISummary<T>
    {
        List<T> GetProduct();
        List<int> CalculateGroupResult(string Field,int Number, List<T> product);
    }
}