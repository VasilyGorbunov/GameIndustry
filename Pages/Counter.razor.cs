using GameIndustry.Models;
using GameIndustry.Services;
using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Counter
    {
        [Inject] public SingletonService singleton { get; set; }
        [Inject] public TransientService transient { get; set; }

        [CascadingParameter] public AppStyle Styles { get; set; }
        

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}
