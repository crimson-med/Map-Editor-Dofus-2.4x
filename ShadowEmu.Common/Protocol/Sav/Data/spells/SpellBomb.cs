

















// Generated on 07/24/2016 18:36:13
using System;
using System.Collections.Generic;
using ShadowEmu.Common.GameData.D2O;

namespace ShadowEmu.Common.Protocol.Data
{

[D2oClass("SpellBombs")]
    
public class SpellBomb : IDataObject
{

public const String MODULE = "SpellBombs";
        public int id;
        public int chainReactionSpellId;
        public int explodSpellId;
        public int wallId;
        public int instantSpellId;
        public int comboCoeff;
        

}

}