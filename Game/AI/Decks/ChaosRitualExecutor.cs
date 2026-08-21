using System;
using System.Collections.Generic;
using System.Linq;
using YGOSharp.OCGWrapper.Enums;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;

namespace WindBot.Game.AI.Decks
{
    [Deck("ChaosRitual", "AI_ChaosRitual")]
    class ChaosRitualExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int TheWorldsGreatestGallantThief = 24203749;
            public const int BlackSkullDragonTheArchfiendDragonOfUnity = 97818130;
            public const int BlackChaos = 98684220;
            public const int FydraulisHarmonia = 70088809;
            public const int SkullArchfiendOfChaos = 24088928;
            public const int FallenOfTheWhiteDragon = 73819701;
            public const int IncredibleEcclesiaTheVirtuous = 55273560;
            public const int CelticMystic = 50073633;
            public const int MulcharmyPurulia = 84192580;
            public const int AshBlossomJoyousSpring = 14558127;
            public const int MaxxC = 23434538;
            public const int Griffoh = 97462632;
            public const int DrollLockBird = 94145021;
            public const int BlackLusterSoldierSoldierOfLightAndDarkness = 70405001;
            public const int MagicianOfDarkChaosBlackChaos = 44001993;
            public const int SpatialTrunade = 2729965;
            public const int RaggedRecordsOfRites = 24461358;
            public const int CrimsonCall = 99398682;
            public const int LightAndDarknessRitual = 33599853;
            public const int TheFallenTheVirtuous = 30271097;
            public const int SpellShatteringSword = 77456448;
            public const int MindShuffle = 24749710;
            public const int AlbaLenatusTheAbyssDragon = 3410461;
            public const int TitanikladTheAshDragon = 41373230;
            public const int AlbionTheBrandedDragon = 87746184;
            public const int RedNovaDragonBurningSoul = 65541655;
            public const int PsychicEndPunisher = 60465049;
            public const int ChaosAngel = 22850702;
            public const int TheCrimsonKing = 67809530;
            public const int RedDragonArchfiend = 70902743;
            public const int EnigmasterPackbit = 72444406;
            public const int EcclesiaAndTheDarkDragon = 78397661;
            public const int StardustDragonVictimSanctuary = 76636978;
            public const int WindPegasusIgnister = 98506199;
            public const int GoldenCloudBeastMalong = 93125329;
            public const int HeraldOfTheArcLight = 79606837;
        }

        public ChaosRitualExecutor(GameAI ai, Duel duel)
            : base(ai, duel)
        {
            AddExecutor(ExecutorType.Activate, CardId.TheWorldsGreatestGallantThief, TheWorldsGreatestGallantThiefActivate);
            // Add other executors here
        }

        private bool mybool = false; // this is a sample variable

        public override bool OnSelectHand()
        {
            // go first
            return true;
        }

        public override void OnNewTurn()
        {
            mybool = false;
            base.OnNewTurn();
        }

        private bool TheWorldsGreatestGallantThiefActivate()
        {
            // your code here
            mybool = true;
            return true;
        }

        // Add other functions here
    }
}
