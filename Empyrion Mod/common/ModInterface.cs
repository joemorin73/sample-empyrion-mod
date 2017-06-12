<<<<<<< HEAD
//#if false
=======
>>>>>>> refs/remotes/lostinplace/master
using System;
using System.Collections.Generic;
using System.Reflection;
using ProtoBuf;

/*
 Tbd:
 - telnet outputs
 - push notification: wenn auf erde und auf mars angegriffen wird
 */

<<<<<<< HEAD
namespace Eleon.Modding {

    [Obfuscation]
    public enum CmdId {
=======
namespace Eleon.Modding
{

    [Obfuscation]
    public enum CmdId
    {
>>>>>>> refs/remotes/lostinplace/master

        Event_Playfield_Loaded,             // PlayfieldLoad
        Event_Playfield_Unloaded,           // PlayfieldLoad
        Request_Playfield_List,             // 
        Event_Playfield_List,               // PlayfieldList

        Request_Playfield_Stats,            // PString = playfield
        Event_Playfield_Stats,              // PlayfieldStats

        Request_Dedi_Stats,                 //
        Event_Dedi_Stats,                   // DediStats

        // *** Structs

        Request_GlobalStructure_List,
        Request_GlobalStructure_Update,     // PString = playfield
        Event_GlobalStructure_List,         // GlobalStructureList

        Request_Structure_Touch,            // Id

        Request_Structure_BlockStatistics,  // Id
        Event_Structure_BlockStatistics,    // IdStructureBlockInfo

        // *** Player

        Event_Player_Connected,             // Id
        Event_Player_Disconnected,          // Id

        Event_Player_ChangedPlayfield,      // IdPlayfield

        Request_Player_Info,                // Id
        Event_Player_Info,                  // PlayerInfo

        Request_Player_List,
        Event_Player_List,                  // IdList

        Request_Player_GetInventory,        // Id
        Request_Player_SetInventory,        // Inventory
        Event_Player_Inventory,             // Inventory
        Request_Player_AddItem,             // IdItemStack

        Request_Player_Credits,             // Id
        Request_Player_SetCredits,          // IdCredits
        Request_Player_AddCredits,          // IdCredits
        Event_Player_Credits,               // IdCredits

        Request_Blueprint_Finish,           // Id (player entity id)
        Request_Blueprint_Resources,        // ?BlueprintResources?

        Request_Player_ChangePlayerfield,   // IdPlayfieldPositionRotation

        Request_Player_ItemExchange,        // ItemExchangeInfo
        Event_Player_ItemExchange,          // ItemExchangeInfo

        Request_Player_SetPlayerInfo,       // PlayerInfoSet

        Event_Player_DisconnectedWaiting,   // Id

        // *** Entity (a player or a structure is also an entity)

        Request_Entity_Teleport,            // IdPositionRotation

        Request_Entity_ChangePlayfield,     // IdPlayfieldPositionRotation
        Request_Entity_Destroy,             // Id

        Request_Entity_PosAndRot,           // Id
        Event_Entity_PosAndRot,             // IdPositionRotation

        Event_Faction_Changed,              // FactionChangeInfo

        Request_Entity_Spawn,               // EntitySpawnInfo

        // *** Misc

        Request_Get_Factions,               // Id (start)
        Event_Get_Factions,                 // FactionInfoList

        Event_Statistics,

        Request_NewEntityId,
        Event_NewEntityId,                  // Id

        Request_AlliancesAll,
        Event_AlliancesAll,                 // AlliancesTable

        Request_AlliancesFaction,           // AlliancesFaction  (isAllied is ignored here)
        Event_AlliancesFaction,             // AlliancesFaction

        Request_Load_Playfield,             // PlayfieldLoad (sec = empty playfield hold time, processId not used)

        Event_ChatMessage,                  // ChatInfo

        Request_ConsoleCommand,             // PString

<<<<<<< HEAD
        // *** Messages

        Request_InGameMessage_SinglePlayer, // IdMsgPrio
        Request_InGameMessage_AllPlayers,   // IdMsgPrio  (ignore id)
=======
        Request_GetBannedPlayers,           // (no param)
        Event_BannedPlayers,                // IdList

        // *** Messages

        Request_InGameMessage_SinglePlayer, // IdMsgPrio (id = player id)
        Request_InGameMessage_AllPlayers,   // IdMsgPrio (ignore id)
        Request_InGameMessage_Faction,      // IdMsgPrio (id = faction id)
>>>>>>> refs/remotes/lostinplace/master
        Request_ShowDialog_SinglePlayer,    // IdMsgPrio

        Event_Ok,
        Event_Error,                        // ErrorInfo
<<<<<<< HEAD
    }

    [Obfuscation]
    public interface ModInterface {
=======

        Event_TraderNPCItemSold,            // TraderNPCItemSoldInfo
        Request_Player_GetAndRemoveInventory,// Id
        Event_Player_GetAndRemoveInventory,  // Inventory
    }

    [Obfuscation]
    public interface ModInterface
    {
>>>>>>> refs/remotes/lostinplace/master
        void Game_Start(ModGameAPI dediAPI);
        void Game_Update();
        void Game_Exit();
        void Game_Event(CmdId eventId, ushort seqNr, object data);
    }

    [Obfuscation]
<<<<<<< HEAD
    public interface ModGameAPI {
        void Console_Write(string txt);

        ulong Game_GetTickTime();

        bool Game_Request(CmdId reqId, ushort seqNr, object data);

        ulong Debug_GetLastPackageReceivedTickTime(int clientId);
        bool Debug_GetNwStatistics(int clientId, out int bytesReceived, out int packagesReceived, out int bytesSent, out int packagesSent);
        float Debug_GetFps();
    }

    [Obfuscation]
    public enum StatisticsType {
        CoreRemoved,    // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
        CoreAdded,      // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
        PlayerDied,     // int1: player entity id, int2: death type (Unknown = 0,Projectile = 1,Explosion = 2,Food = 3,Oxygen = 4,Disease = 5,Drowning = 6,Fall = 7,Suicide = 8), int3: (optional) other entity involved
=======
    public interface ModGameAPI
    {
        void Console_Write(string txt);
        ulong Game_GetTickTime();
        bool Game_Request(CmdId reqId, ushort seqNr, object data);
    }

    [Obfuscation]
    public enum StatisticsType
    {
        CoreRemoved,    // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
        CoreAdded,      // int1: structure id, int2: destryoing entity id, int3: (optional) controlling entity id
        PlayerDied,     // int1: player entity id, int2: death type (Unknown = 0,Projectile = 1,Explosion = 2,Food = 3,Oxygen = 4,Disease = 5,Drowning = 6,Fall = 7,Suicide = 8), int3: (optional) other entity involved, int4: (optional) other entity CV/SV/HV id
>>>>>>> refs/remotes/lostinplace/master
        StructOnOff,    // int1: structure id, int2: changing entity id, int3: 0 = off, 1 = on
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class EntitySpawnInfo {
=======
    public class EntitySpawnInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int forceEntityId;
        [ProtoMember(2)]
        public string playfield;
        [ProtoMember(3)]
        public PVector3 pos;
        [ProtoMember(4)]
        public PVector3 rot;
        [ProtoMember(5)]
        public string name;
        [ProtoMember(6)]
        public byte type;   // BA = 2, CV = 3, SV = 4, HV = 5, AstVoxel = 7
        [ProtoMember(7)]
        public string prefabName;
        [ProtoMember(8)]
        public byte factionGroup;
        [ProtoMember(9)]
        public int factionId;

<<<<<<< HEAD
        public EntitySpawnInfo() {
=======
        public EntitySpawnInfo()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public struct FactionInfo {
=======
    public struct FactionInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public byte origin;
        [ProtoMember(2)]
        public int factionId;
        [ProtoMember(3)]
        public string name;
        [ProtoMember(4)]
        public string abbrev;

<<<<<<< HEAD
        public FactionInfo(byte nOrigin, int nFactionId, string nName, string nAbbrev) {
=======
        public FactionInfo(byte nOrigin, int nFactionId, string nName, string nAbbrev)
        {
>>>>>>> refs/remotes/lostinplace/master
            origin = nOrigin;
            factionId = nFactionId;
            name = nName;
            abbrev = nAbbrev;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class FactionInfoList {
        [ProtoMember(1)]
        public List<FactionInfo> factions;

        public FactionInfoList() {
=======
    public class FactionInfoList
    {
        [ProtoMember(1)]
        public List<FactionInfo> factions;

        public FactionInfoList()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class StatisticsParam {
=======
    public class StatisticsParam
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public StatisticsType type;
        [ProtoMember(2)]
        public int int1;
        [ProtoMember(3)]
        public int int2;
        [ProtoMember(4)]
        public int int3;
<<<<<<< HEAD

        public StatisticsParam() {
        }

        public StatisticsParam(StatisticsType nType, int nInt1, int nInt2, int nInt3) {
=======
        [ProtoMember(5)]
        public int int4;

        public StatisticsParam()
        {
        }

        public StatisticsParam(StatisticsType nType, int nInt1, int nInt2, int nInt3, int nInt4)
        {
>>>>>>> refs/remotes/lostinplace/master
            type = nType;
            int1 = nInt1;
            int2 = nInt2;
            int3 = nInt3;
<<<<<<< HEAD
=======
            int4 = nInt4;
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class Id {
        [ProtoMember(1)]
        public int id;

        public Id() {
        }

        public Id(int nId) {
=======
    public class Id
    {
        [ProtoMember(1)]
        public int id;

        public Id()
        {
        }

        public Id(int nId)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdMsgPrio {
=======
    public class IdMsgPrio
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public string msg;
        [ProtoMember(3)]
        public byte prio;
        [ProtoMember(4)]
        public float time;

<<<<<<< HEAD
        public IdMsgPrio() {
        }

        public IdMsgPrio(int nId, string nMsg, byte nPrio, float nTime) {
=======
        public IdMsgPrio()
        {
        }

        public IdMsgPrio(int nId, string nMsg, byte nPrio, float nTime)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            msg = nMsg;
            prio = nPrio;
            time = nTime;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PlayfieldList {
        [ProtoMember(1)]
        public List<string> playfields;

        public PlayfieldList() {
=======
    public class PlayfieldList
    {
        [ProtoMember(1)]
        public List<string> playfields;

        public PlayfieldList()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class FactionChangeInfo {
=======
    public class FactionChangeInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public byte factionGroup;
        [ProtoMember(3)]
        public int factionId;

<<<<<<< HEAD
        public FactionChangeInfo() {
        }
        public FactionChangeInfo(int nId, byte nFactionGroup, int nFactionId) {
=======
        public FactionChangeInfo()
        {
        }
        public FactionChangeInfo(int nId, byte nFactionGroup, int nFactionId)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            factionGroup = nFactionGroup;
            factionId = nFactionId;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public struct GlobalStructureInfo {
=======
    public struct GlobalStructureInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public byte type;   // BA = 2, CV = 3, SV = 4, HV = 5, AstVoxel = 7
        [ProtoMember(3)]
        public byte factionGroup;
        [ProtoMember(4)]
        public int factionId;
        [ProtoMember(5)]
        public string name;
        [ProtoMember(6)]
        public long lastVisitedUTC;
        [ProtoMember(7)]
        public PVector3 pos;
        [ProtoMember(8)]
        public PVector3 rot;
        [ProtoMember(9)]
        public bool powered;
        [ProtoMember(10)]
        public int fuel;
        [ProtoMember(11)]
        public int cntDevices;
        [ProtoMember(12)]
        public int cntBlocks;
        [ProtoMember(13)]
        public int cntTriangles;
        [ProtoMember(14)]
        public int cntLights;
        [ProtoMember(15)]
        public int classNr;
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class GlobalStructureList {
        [ProtoMember(1)]
        public Dictionary<string, List<GlobalStructureInfo>> globalStructures;

        public GlobalStructureList() {
=======
    public class GlobalStructureList
    {
        [ProtoMember(1)]
        public Dictionary<string, List<GlobalStructureInfo>> globalStructures;

        public GlobalStructureList()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdPlayfield {
=======
    public class IdPlayfield
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public string playfield;

<<<<<<< HEAD
        public IdPlayfield() {
        }

        public IdPlayfield(int nId, string nPlayfield) {
=======
        public IdPlayfield()
        {
        }

        public IdPlayfield(int nId, string nPlayfield)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            playfield = nPlayfield;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PlayfieldLoad {
=======
    public class PlayfieldLoad
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public float sec;
        [ProtoMember(2)]
        public string playfield;
        [ProtoMember(3)]
        public int processId;

<<<<<<< HEAD
        public PlayfieldLoad() {
        }

        public PlayfieldLoad(float nSecs, string nPlayefield, int nProcessId) {
=======
        public PlayfieldLoad()
        {
        }

        public PlayfieldLoad(float nSecs, string nPlayefield, int nProcessId)
        {
>>>>>>> refs/remotes/lostinplace/master
            sec = nSecs;
            playfield = nPlayefield;
            processId = nProcessId;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PlayfieldStats {
=======
    public class PlayfieldStats
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public string playfield;
        [ProtoMember(2)]
        public float fps;
        [ProtoMember(3)]
        public int mem;
        [ProtoMember(4)]
        public int players;
        [ProtoMember(5)]
        public int mobs;
        [ProtoMember(6)]
        public int structs;
        [ProtoMember(7)]
        public int devices;
        [ProtoMember(8)]
        public int chunks;
        [ProtoMember(9)]
        public int uptime;
        [ProtoMember(10)]
        public int processId;

<<<<<<< HEAD
        public PlayfieldStats() {
=======
        public PlayfieldStats()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class DediStats {
=======
    public class DediStats
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public float fps;
        [ProtoMember(2)]
        public int mem;
        [ProtoMember(3)]
        public int players;
        [ProtoMember(4)]
        public int uptime;
        [ProtoMember(5)]
        public ulong ticks;

<<<<<<< HEAD
        public DediStats() {
=======
        public DediStats()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PString {
        [ProtoMember(2)]
        public string pstr;

        public PString() {
        }

        public PString(string nString) {
=======
    public class PString
    {
        [ProtoMember(2)]
        public string pstr;

        public PString()
        {
        }

        public PString(string nString)
        {
>>>>>>> refs/remotes/lostinplace/master
            pstr = nString;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdList {
        [ProtoMember(1)]
        public List<int> list;

        public IdList() {
=======
    public class IdList
    {
        [ProtoMember(1)]
        public List<int> list;

        public IdList()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdCredits {
=======
    public class IdCredits
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public double credits;

<<<<<<< HEAD
        public IdCredits() {
        }

        public IdCredits(int nId, double nCredits) {
=======
        public IdCredits()
        {
        }

        public IdCredits(int nId, double nCredits)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            credits = nCredits;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public struct PVector3 {
=======
    public struct PVector3
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public float x;
        [ProtoMember(2)]
        public float y;
        [ProtoMember(3)]
        public float z;

<<<<<<< HEAD
        public PVector3(float nX, float nY, float nZ) {
=======
        public PVector3(float nX, float nY, float nZ)
        {
>>>>>>> refs/remotes/lostinplace/master
            x = nX; y = nY; z = nZ;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class ItemExchangeInfo {
=======
    public class ItemExchangeInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public string title;
        [ProtoMember(3)]
        public string desc;
        [ProtoMember(4)]
        public string buttonText;
        [ProtoMember(5)]
        public ItemStack[] items;

<<<<<<< HEAD
        public ItemExchangeInfo() {
        }

        public ItemExchangeInfo(int nId, string nTitle, string nDesc, string nButtonText, ItemStack[] nItems) {
=======
        public ItemExchangeInfo()
        {
        }

        public ItemExchangeInfo(int nId, string nTitle, string nDesc, string nButtonText, ItemStack[] nItems)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            title = nTitle;
            desc = nDesc;
            buttonText = nButtonText;
            items = nItems;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdPlayfieldPositionRotation {
=======
    public class IdPlayfieldPositionRotation
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public PVector3 pos;
        [ProtoMember(3)]
        public PVector3 rot;
        [ProtoMember(4)]
        public string playfield;

<<<<<<< HEAD
        public IdPlayfieldPositionRotation() {
        }

        public IdPlayfieldPositionRotation(int nId, string nPlayfield, PVector3 nPos, PVector3 nRot) {
=======
        public IdPlayfieldPositionRotation()
        {
        }

        public IdPlayfieldPositionRotation(int nId, string nPlayfield, PVector3 nPos, PVector3 nRot)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            pos = nPos;
            rot = nRot;
            playfield = nPlayfield;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdPositionRotation {
=======
    public class IdPositionRotation
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public PVector3 pos;
        [ProtoMember(3)]
        public PVector3 rot;

<<<<<<< HEAD
        public IdPositionRotation() {
        }

        public IdPositionRotation(int nId, PVector3 nPos, PVector3 nRot) {
=======
        public IdPositionRotation()
        {
        }

        public IdPositionRotation(int nId, PVector3 nPos, PVector3 nRot)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            pos = nPos;
            rot = nRot;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdItemStack {
=======
    public class IdItemStack
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public ItemStack itemStack;

<<<<<<< HEAD
        public IdItemStack() {
        }

        public IdItemStack(int nId, ItemStack nItemStack) {
=======
        public IdItemStack()
        {
        }

        public IdItemStack(int nId, ItemStack nItemStack)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            itemStack = nItemStack;
        }
    }

    [Obfuscation]
<<<<<<< HEAD
    public enum ErrorType : byte {
=======
    public enum ErrorType : byte
    {
>>>>>>> refs/remotes/lostinplace/master
        None,
        MissingParameter,
        PlayerIdNotFound,
        PlayfieldOfPlayerNotFound,
        PlayfieldConnectionNotFound,
        EntityIdNotFound,
        CouldNotAddItemToInventory,
        CouldNotRemoveItemFromInventory,
        BlueprintError,
        NotEnoughCredits,
        EntityTypeNotSupported,
        NoIdlePlayfieldFound,
        PlayfieldCannotBeLoaded,
<<<<<<< HEAD
=======
        PlayfieldAlreadyLoaded,
        CommandNotImplemented
>>>>>>> refs/remotes/lostinplace/master
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class ErrorInfo {
        [ProtoMember(1)]
        public ErrorType errorType;

        public ErrorInfo() {
        }

        public ErrorInfo(ErrorType nErrorType) {
=======
    public class ErrorInfo
    {
        [ProtoMember(1)]
        public ErrorType errorType;

        public ErrorInfo()
        {
        }

        public ErrorInfo(ErrorType nErrorType)
        {
>>>>>>> refs/remotes/lostinplace/master
            errorType = nErrorType;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PlayerInfoSet {
=======
    public class PlayerInfoSet
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int entityId;
        [ProtoMember(2)]
        public string startPlayfield;
        [ProtoMember(3)]
        public int? health;
        [ProtoMember(4)]
        public int? healthMax;
        [ProtoMember(5)]
        public int? stamina;
        [ProtoMember(6)]
        public int? staminaMax;
        [ProtoMember(7)]
        public int? food;
        [ProtoMember(8)]
        public int? foodMax;
        [ProtoMember(9)]
        public int? oxygen;
        [ProtoMember(10)]
        public int? oxygenMax;
        [ProtoMember(11)]
        public int? radiation;
        [ProtoMember(12)]
        public int? radiationMax;
        [ProtoMember(13)]
        public int? bodyTemp;
        [ProtoMember(14)]
        public int? bodyTempMax;
        [ProtoMember(15)]
        public int? experiencePoints;
        [ProtoMember(16)]
        public int? upgradePoints;

<<<<<<< HEAD
        public PlayerInfoSet() {
=======
        public PlayerInfoSet()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class PlayerInfo {
=======
    public class PlayerInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int clientId;
        [ProtoMember(2)]
        public int entityId;
        [ProtoMember(3)]
        public string steamId;
        [ProtoMember(4)]
        public string steamOwnerId;
        [ProtoMember(5)]
        public string playerName;
        [ProtoMember(6)]
        public string playfield;
        [ProtoMember(7)]
        public string startPlayfield;
        [ProtoMember(8)]
        public PVector3 pos;
        [ProtoMember(9)]
        public PVector3 rot;
        [ProtoMember(10)]
        public byte origin;
        [ProtoMember(11)]
        public byte factionGroup;
        [ProtoMember(12)]
        public int factionId;
        [ProtoMember(13)]
        public byte factionRole;
        [ProtoMember(14)]
        public float health;
        [ProtoMember(15)]
        public float healthMax;
        [ProtoMember(16)]
        public float oxygen;
        [ProtoMember(17)]
        public float oxygenMax;
        [ProtoMember(18)]
        public float stamina;
        [ProtoMember(19)]
        public float staminaMax;
        [ProtoMember(20)]
<<<<<<< HEAD
        public float radiation;
        [ProtoMember(21)]
        public float radiationMax;
        [ProtoMember(22)]
        public float bodyTemp;
        [ProtoMember(23)]
        public float bodyTempMax;
        [ProtoMember(24)]
        public int kills;
        [ProtoMember(25)]
        public int died;
        [ProtoMember(26)]
        public double credits;
        [ProtoMember(27)]
        public ItemStack[] toolbar;
        [ProtoMember(28)]
        public ItemStack[] bag;
        [ProtoMember(29)]
        public int exp;
        [ProtoMember(30)]
        public int upgrade;
        [ProtoMember(31)]
        public float bpRemainingTime;
        [ProtoMember(32)]
        public Dictionary<int, float> bpResourcesInFactory;
        [ProtoMember(33)]
        public string bpInFactory;
        [ProtoMember(34)]
        public List<string> producedPrefabs;
        [ProtoMember(35)]
        public int ping;
        [ProtoMember(36)]
        public int permission;  // Player = 0, GameMaster = 3, Moderator = 6, Admin = 9 

        public PlayerInfo() {
=======
        public float food;
        [ProtoMember(21)]
        public float foodMax;
        [ProtoMember(22)]
        public float radiation;
        [ProtoMember(23)]
        public float radiationMax;
        [ProtoMember(24)]
        public float bodyTemp;
        [ProtoMember(25)]
        public float bodyTempMax;
        [ProtoMember(26)]
        public int kills;
        [ProtoMember(27)]
        public int died;
        [ProtoMember(28)]
        public double credits;
        [ProtoMember(29)]
        public ItemStack[] toolbar;
        [ProtoMember(30)]
        public ItemStack[] bag;
        [ProtoMember(31)]
        public int exp;
        [ProtoMember(32)]
        public int upgrade;
        [ProtoMember(33)]
        public float bpRemainingTime;
        [ProtoMember(34)]
        public Dictionary<int, float> bpResourcesInFactory;
        [ProtoMember(35)]
        public string bpInFactory;
        [ProtoMember(36)]
        public List<string> producedPrefabs;
        [ProtoMember(37)]
        public int ping;
        [ProtoMember(38)]
        public int permission;  // Player = 0, GameMaster = 3, Moderator = 6, Admin = 9 

        public PlayerInfo()
        {
>>>>>>> refs/remotes/lostinplace/master
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class Inventory {
=======
    public class Inventory
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int playerId;
        [ProtoMember(2)]
        public ItemStack[] toolbelt;
        [ProtoMember(3)]
        public ItemStack[] bag;

<<<<<<< HEAD
        public Inventory() {
        }

        public Inventory(int nPlayerId, ItemStack[] nToolbelt, ItemStack[] nBag) {
=======
        public Inventory()
        {
        }

        public Inventory(int nPlayerId, ItemStack[] nToolbelt, ItemStack[] nBag)
        {
>>>>>>> refs/remotes/lostinplace/master
            playerId = nPlayerId;
            toolbelt = nToolbelt;
            bag = nBag;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public struct ItemStack {
=======
    public struct ItemStack
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public int count;
        [ProtoMember(3)]
        public byte slotIdx;
        [ProtoMember(4)]
        public int ammo;
        [ProtoMember(5)]
        public int decay;

<<<<<<< HEAD
        public ItemStack(int nid, int ncount) {
=======
        public ItemStack(int nid, int ncount)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nid;
            count = ncount;
            slotIdx = 0;
            ammo = decay = 0;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class BlueprintResources {
=======
    public class BlueprintResources
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int PlayerId;
        [ProtoMember(2)]
        public List<ItemStack> ItemStacks;
        [ProtoMember(3)]
        public bool ReplaceExisting; // true = replace Blueprint Factory resource items, false: add items

<<<<<<< HEAD
        public BlueprintResources() {
        }

        public BlueprintResources(int playerId, List<ItemStack> itemStacks, bool replaceExisting) {
=======
        public BlueprintResources()
        {
        }

        public BlueprintResources(int playerId, List<ItemStack> itemStacks, bool replaceExisting)
        {
>>>>>>> refs/remotes/lostinplace/master
            PlayerId = playerId;
            ItemStacks = itemStacks;
            ReplaceExisting = replaceExisting;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class ChatInfo {
=======
    public class ChatInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int playerId;
        [ProtoMember(2)]
        public string msg;
        [ProtoMember(3)]
        public int recipientEntityId;
        [ProtoMember(4)]
        public int recipientFactionId;
        [ProtoMember(5)]
        public byte type;       // ToFaction = 7, ToPlayer = 8, PlayerToServer = 9

<<<<<<< HEAD
        public ChatInfo() {
        }

        public ChatInfo(int nPlayerId, string nMsg, int nRecipientEntityId, int nRecipientFactionId, byte nType) {
=======
        public ChatInfo()
        {
        }

        public ChatInfo(int nPlayerId, string nMsg, int nRecipientEntityId, int nRecipientFactionId, byte nType)
        {
>>>>>>> refs/remotes/lostinplace/master
            playerId = nPlayerId;
            msg = nMsg;
            recipientEntityId = nRecipientEntityId;
            recipientFactionId = nRecipientFactionId;
            type = nType;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class AlliancesTable {
        [ProtoMember(1)]
        public HashSet<int> alliances;

        public AlliancesTable() {
        }

        public AlliancesTable(HashSet<int> nAlliances) {
            alliances = new HashSet<int>();
            foreach (int id in nAlliances) {
=======
    public class AlliancesTable
    {

        // Contains all relations of relevant alliances. 
        // Per default all faction within the same origin are in alliance and not allianced in different origins. So only
        // canceled alliances within the same origin and alliances within different origins need to be in the hashset below.
        // A 32 bit value within the hashset contains two factions in relation: the upper 16 bits contain faction1, the lower faction2.
        // facId1 = (v >> 16) & 0xffff;
        // facId2 = v & 0xffff;
        [ProtoMember(1)]
        public HashSet<int> alliances;

        public AlliancesTable()
        {
        }

        public AlliancesTable(HashSet<int> nAlliances)
        {
            alliances = new HashSet<int>();
            foreach (int id in nAlliances)
            {
>>>>>>> refs/remotes/lostinplace/master
                alliances.Add(id);
            }
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class AlliancesFaction {
=======
    public class AlliancesFaction
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int faction1Id;
        [ProtoMember(2)]
        public int faction2Id;
        [ProtoMember(3)]
        public bool isAllied;

<<<<<<< HEAD
        public AlliancesFaction() {
        }

        public AlliancesFaction(int nFaction1Id, int nFaction2Id, bool nIsAllied) {
=======
        public AlliancesFaction()
        {
        }

        public AlliancesFaction(int nFaction1Id, int nFaction2Id, bool nIsAllied)
        {
>>>>>>> refs/remotes/lostinplace/master
            faction1Id = nFaction1Id;
            faction2Id = nFaction2Id;
            isAllied = nIsAllied;
        }
    }

    [Obfuscation]
    [ProtoContract]
<<<<<<< HEAD
    public class IdStructureBlockInfo {
=======
    public class IdStructureBlockInfo
    {
>>>>>>> refs/remotes/lostinplace/master
        [ProtoMember(1)]
        public int id;
        [ProtoMember(2)]
        public Dictionary<int, int> blockStatistics;

<<<<<<< HEAD
        public IdStructureBlockInfo() {
        }

        public IdStructureBlockInfo(int nId, Dictionary<int, int> nBblockStatistics) {
=======
        public IdStructureBlockInfo()
        {
        }

        public IdStructureBlockInfo(int nId, Dictionary<int, int> nBblockStatistics)
        {
>>>>>>> refs/remotes/lostinplace/master
            id = nId;
            blockStatistics = nBblockStatistics;
        }
    }
<<<<<<< HEAD
}
//#endif
=======

    [Obfuscation]
    [ProtoContract]
    public class BannedPlayerData
    {
        [ProtoContract]
        public struct BanEntry
        {
            [ProtoMember(1)]
            public ulong steam64Id;
            [ProtoMember(2)]
            public long dateTime;

            public BanEntry(ulong id, DateTime time)
            {
                steam64Id = id;
                dateTime = time.ToBinary();
            }
        }

        [ProtoMember(1)]
        public List<BanEntry> BannedPlayers;

        public BannedPlayerData()
        {
            BannedPlayers = new List<BanEntry>();
        }
    }

    [Obfuscation]
    [ProtoContract]
    public class TraderNPCItemSoldInfo
    {
        [ProtoMember(1)]
        public int playerEntityId;  // player that bought it
        [ProtoMember(2)]
        public int traderEntityId;
        [ProtoMember(3)]
        public string traderType;
        [ProtoMember(4)]
        public int structEntityId;  // where the trader is on
        [ProtoMember(5)]
        public int boughtItemId;
        [ProtoMember(6)]
        public int boughtItemCount;
        [ProtoMember(7)]
        public int boughtItemPrice; // price per item

        public TraderNPCItemSoldInfo()
        {
        }

        public TraderNPCItemSoldInfo(int _playerEntityId, int _traderEntityId, string _traderType, int _structEntityId, int _boughtItemId, int _boughtItemCount, int _boughtItemPrice)
        {
            playerEntityId = _playerEntityId;
            traderEntityId = _traderEntityId;
            traderType = _traderType;
            structEntityId = _structEntityId;
            boughtItemId = _boughtItemId;
            boughtItemCount = _boughtItemCount;
            boughtItemPrice = _boughtItemPrice;
        }
    }
}
>>>>>>> refs/remotes/lostinplace/master
