using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDataLayer;

namespace ClaimsBusinessLayer
{
    interface IPlanCodeDao
    {
        bool AddPlan(PlanCode planCode);
        bool RemovePlan(PlanCode planCodeId);
        List<PlanCode> ViewPlan();
        bool EditPlan(PlanCode planCode);
    }
}
