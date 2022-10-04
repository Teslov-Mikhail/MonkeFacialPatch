using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace ApePlanet
{
    public class Hediff_TooltipDescription : HediffWithComps
    {
        public override string TipStringExtra => def.description;
    }
}
