using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

using HarmonyLib;

namespace ApePlanet
{
    [HarmonyPatch(typeof(PawnGenerator), "GenerateBodyType")]
    public class Patch_PawnGenerator_GenerateBodyType
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn pawn)
        {
            if (pawn.def.HasModExtension<DefModExt_BodyCorrection>())
            {
                DefModExt_BodyCorrection ext = pawn.def.GetModExtension<DefModExt_BodyCorrection>();
                if (pawn.gender == Gender.Male && !ext.maleBodyTypes.Contains(pawn.story.bodyType))
                {
                    pawn.story.bodyType = ext.maleBodyTypes.RandomElement();
                }
                else if (pawn.gender == Gender.Female && !ext.femaleBodyTypes.Contains(pawn.story.bodyType))
                {
                    pawn.story.bodyType = ext.femaleBodyTypes.RandomElement();
                }
            }
        }
    }
}
