

















// Generated on 07/24/2016 18:36:10
using System;
using System.Collections.Generic;
using ShadowEmu.Common.GameData.D2O;

namespace ShadowEmu.Common.Protocol.Data
{

[D2oClass("SkinPositions")]
    
public class SkinPosition : IDataObject
{

private const String MODULE = "SkinPositions";
        public uint id;
        public List<TransformData> transformation;
        public List<String> clip;
        public List<uint> skin;
        

}

}