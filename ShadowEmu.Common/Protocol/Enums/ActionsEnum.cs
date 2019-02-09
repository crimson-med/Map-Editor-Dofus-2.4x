﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowEmu.Common.Protocol.Enums
{
    public enum ActionsEnum
    {
        ACTION_ENDS_TURN = -2,
        ACTION_INTERNAL_SEND_ACTION_BUFFER = -1,
        ACTION_NO_OPERATION = 0,
        ACTION_CHARACTER_MOVEMENT = 1,
        PARAM_CLIENT_OPEN_UI_GUILD_TELEPORT_HOUSE = 1,
        ACTION_CHARACTER_CHANGE_MAP = 2,
        PARAM_CLIENT_OPEN_UI_GUILD_TELEPORT_FARM = 2,
        ACTION_CHARACTER_MOVE = 3,
        ACTION_CHARACTER_TELEPORT_ON_SAME_MAP = 4,
        ACTION_CHARACTER_PUSH = 5,
        ACTION_CHARACTER_PULL = 6,
        ACTION_CHARACTER_DIVORCE_WIFE_OR_HUSBAND = 7,
        ACTION_CHARACTER_EXCHANGE_PLACES = 8,
        ACTION_CHARACTER_DODGE_HIT = 9,
        ACTION_CHARACTER_LEARN_EMOTICON = 10,
        ACTION_CHARACTER_SET_DIRECTION = 11,
        ACTION_CHARACTER_CREATE_GUILD = 12,
        ACTION_USE_PUSHPULL_ELEMENT = 14,
        ACTION_AREA_CHANGE_ALIGNMENT = 15,
        ACTION_AREA_GIVE_KAMAS = 16,
        ACTION_SCRIPT_START = 17,
        ACTION_AREA_DUNGEON_ATTACKED = 20,
        ACTION_GAIN_AREA_KAMAS = 21,
        ACTION_AREA_DUNGEON_CITY_OPENED = 23,
        ACTION_AREA_DUNGEON_HEART_OPENED = 24,
        ACTION_AREA_DUNGEON_HEART_CLOSED = 25,
        ACTION_AREA_CHANGE_ALIGNMENT_SUB = 26,
        ACTION_QUEST_OBJECTIVE_VALIDATE = 30,
        ACTION_QUEST_STEP_VALIDATE = 31,
        ACTION_QUEST_QUEST_VALIDATE = 32,
        ACTION_QUEST_STEP_START = 33,
        ACTION_QUEST_START = 34,
        ACTION_QUEST_CHECK_STARTED_OBJECTIVES = 35,
        ACTION_QUEST_RESET = 36,
        ACTION_START_DIALOG_WITH_NPC = 40,
        ACTION_CARRY_CHARACTER = 50,
        ACTION_THROW_CARRIED_CHARACTER = 51,
        ACTION_NO_MORE_CARRIED = 52,
        ACTION_SEQUENCE_END = 70,
        ACTION_CHARACTER_MOVEMENT_POINTS_STEAL = 77,
        ACTION_CHARACTER_MOVEMENT_POINTS_WIN = 78,
        ACTION_CHARACTER_MULTIPLY_RECEIVED_DAMAGE_OR_GIVE_LIFE_WITH_RATIO = 79,
        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_PUSH = 80,
        ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_ELEMENT = 81,
        ACTION_CHARACTER_LIFE_POINTS_STEAL_WITHOUT_BOOST = 82,
        ACTION_SEQUENCE_START = 83,
        ACTION_CHARACTER_ACTION_POINTS_STEAL = 84,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_WATER = 85,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_EARTH = 86,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_AIR = 87,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_FROM_FIRE = 88,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE = 89,
        ACTION_CHARACTER_DISPATCH_LIFE_POINTS_PERCENT = 90,
        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_WATER = 91,
        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_EARTH = 92,
        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_AIR = 93,
        ACTION_CHARACTER_LIFE_POINTS_STEAL_FROM_FIRE = 94,
        ACTION_CHARACTER_LIFE_POINTS_STEAL = 95,
        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_WATER = 96,
        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_EARTH = 97,
        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_AIR = 98,
        ACTION_CHARACTER_LIFE_POINTS_LOST_FROM_FIRE = 99,
        ACTION_CHARACTER_LIFE_POINTS_LOST = 100,
        ACTION_CHARACTER_ACTION_POINTS_LOST = 101,
        ACTION_CHARACTER_ACTION_POINTS_USE = 102,
        ACTION_CHARACTER_DEATH = 103,
        ACTION_CHARACTER_ACTION_TACKLED = 104,
        ACTION_CHARACTER_LIFE_LOST_MODERATOR = 105,
        ACTION_CHARACTER_SPELL_REFLECTOR = 106,
        ACTION_CHARACTER_LIFE_LOST_REFLECTOR = 107,
        ACTION_CHARACTER_LIFE_POINTS_WIN = 108,
        ACTION_CHARACTER_LIFE_POINTS_LOST_CASTER = 109,
        ACTION_CHARACTER_BOOST_LIFE_POINTS = 110,
        ACTION_CHARACTER_BOOST_ACTION_POINTS = 111,
        ACTION_CHARACTER_BOOST_DAMAGES = 112,
        ACTION_CHARACTER_MULTIPLY_DAMAGES = 114,
        ACTION_CHARACTER_BOOST_CRITICAL_HIT = 115,
        ACTION_CHARACTER_DEBOOST_RANGE = 116,
        ACTION_CHARACTER_BOOST_RANGE = 117,
        ACTION_CHARACTER_BOOST_STRENGTH = 118,
        ACTION_CHARACTER_BOOST_AGILITY = 119,
        ACTION_CHARACTER_ACTION_POINTS_WIN = 120,
        ACTION_CHARACTER_BOOST_DAMAGES_FOR_ALL_GAME = 121,
        ACTION_CHARACTER_BOOST_CRITICAL_MISS = 122,
        ACTION_CHARACTER_BOOST_CHANCE = 123,
        ACTION_CHARACTER_BOOST_WISDOM = 124,
        ACTION_CHARACTER_BOOST_VITALITY = 125,
        ACTION_CHARACTER_BOOST_INTELLIGENCE = 126,
        ACTION_CHARACTER_MOVEMENT_POINTS_LOST = 127,
        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS = 128,
        ACTION_CHARACTER_MOVEMENT_POINTS_USE = 129,
        ACTION_CHARACTER_STEAL_GOLD = 130,
        ACTION_CHARACTER_MANA_USE_KILL_LIFE = 131,
        ACTION_CHARACTER_REMOVE_ALL_EFFECTS = 132,
        ACTION_CHARACTER_ACTION_POINTS_LOST_CASTER = 133,
        ACTION_CHARACTER_MOVEMEMT_POINTS_LOST_CASTER = 134,
        ACTION_CHARACTER_DEBOOST_RANGE_CASTER = 135,
        ACTION_CHARACTER_BOOST_RANGE_CASTER = 136,
        ACTION_CHARACTER_BOOST_DAMAGES_CASTER = 137,
        ACTION_CHARACTER_BOOST_DAMAGES_PERCENT = 138,
        ACTION_CHARACTER_ENERGY_POINTS_WIN = 139,
        ACTION_CHARACTER_PASS_NEXT_TURN = 140,
        ACTION_CHARACTER_KILL = 141,
        ACTION_CHARACTER_BOOST_PHYSICAL_DAMAGES = 142,
        ACTION_CHARACTER_LIFE_POINTS_WIN_WITHOUT_BOOST = 143,
        ACTION_CHARACTER_LIFE_POINTS_LOST_WITHOUT_BOOST = 144,
        ACTION_CHARACTER_DEBOOST_DAMAGES = 145,
        ACTION_CHARACTER_CURSE = 146,
        ACTION_CHARACTER_RESURECT_ALLY_IN_FIGHT = 147,
        ACTION_CHARACTER_ADD_FOLLOWING_CHARACTER = 148,
        ACTION_CHARACTER_CHANGE_LOOK = 149,
        ACTION_CHARACTER_MAKE_INVISIBLE = 150,
        ACTION_SPELL_INVISIBLE_OBSTACLE = 151,
        ACTION_CHARACTER_DEBOOST_CHANCE = 152,
        ACTION_CHARACTER_DEBOOST_VITALITY = 153,
        ACTION_CHARACTER_DEBOOST_AGILITY = 154,
        ACTION_CHARACTER_DEBOOST_INTELLIGENCE = 155,
        ACTION_CHARACTER_DEBOOST_WISDOM = 156,
        ACTION_CHARACTER_DEBOOST_STRENGTH = 157,
        ACTION_CHARACTER_BOOST_MAXIMUM_WEIGHT = 158,
        ACTION_CHARACTER_DEBOOST_MAXIMUM_WEIGHT = 159,
        ACTION_CHARACTER_BOOST_ACTION_POINTS_LOST_DODGE = 160,
        ACTION_CHARACTER_BOOST_MOVEMENT_POINTS_LOST_DODGE = 161,
        ACTION_CHARACTER_DEBOOST_ACTION_POINTS_LOST_DODGE = 162,
        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS_LOST_DODGE = 163,
        ACTION_CHARACTER_BOOST_WEAPON_DAMAGE_PERCENT = 165,
        ACTION_CHARACTER_DEBOOST_ACTION_POINTS = 168,
        ACTION_CHARACTER_DEBOOST_MOVEMENT_POINTS = 169,
        ACTION_CHARACTER_LIFE_POINTS_WIN_IN_RP = 170,
        ACTION_CHARACTER_DEBOOST_CRITICAL_HIT = 171,
        ACTION_CHARACTER_DEBOOST_MAGICAL_REDUCTION = 172,
        ACTION_CHARACTER_DEBOOST_PHYSICAL_REDUCTION = 173,
        ACTION_CHARACTER_BOOST_INITIATIVE = 174,
        ACTION_CHARACTER_DEBOOST_INITIATIVE = 175,
        ACTION_CHARACTER_BOOST_MAGIC_FIND = 176,
        ACTION_CHARACTER_DEBOOST_MAGIC_FIND = 177,
        ACTION_CHARACTER_BOOST_HEAL_BONUS = 178,
        ACTION_CHARACTER_DEBOOST_HEAL_BONUS = 179,
        ACTION_CHARACTER_ADD_DOUBLE = 180,
        ACTION_SUMMON_CREATURE = 181,
        ACTION_CHARACTER_BOOST_MAXIMUM_SUMMONED_CREATURES = 182,
        ACTION_CHARACTER_BOOST_MAGICAL_REDUCTION = 183,
        ACTION_CHARACTER_BOOST_PHYSICAL_REDUCTION = 184,
        ACTION_SUMMON_STATIC_CREATURE = 185,
        ACTION_CHARACTER_DEBOOST_DAMAGES_PERCENT = 186,
        ACTION_CHARACTER_ALIGNMENT_RANK_SET = 187,
        ACTION_CHARACTER_ALIGNMENT_SIDE_SET = 188,
        ACTION_CHARACTER_ALIGNMENT_VALUE_SET = 189,
        ACTION_CHARACTER_ALIGNMENT_VALUE_MODIFICATION = 190,
        ACTION_CHARACTER_INVENTORY_CLEAR = 191,
        ACTION_CHARACTER_INVENTORY_REMOVE_ITEM = 192,
        ACTION_CHARACTER_INVENTORY_ADD_ITEM = 193,
        ACTION_CHARACTER_INVENTORY_GAIN_KAMAS = 194,
        ACTION_CHARACTER_INVENTORY_LOSE_KAMAS = 195,
        ACTION_CHARACTER_OPEN_MY_STORAGE = 196,
        ACTION_CHARACTER_TRANSFORM = 197,
        ACTION_CHARACTER_CLEAR_ALL_JOB = 198,
        ACTION_CHARACTER_REPAIR_OBJECT = 199,
        ACTION_DECORS_PLAY_OBJECT_ANIMATION = 200,
        ACTION_DECORS_ADD_OBJECT = 201,
        ACTION_DECORS_REVEAL_UNVISIBLE = 202,
        ACTION_DECORS_OBSTACLE_CLOSE = 203,
        ACTION_DECORS_OBSTACLE_OPEN = 204,
        ACTION_CHARACTER_CHANGE_RESTRICTION = 205,
        ACTION_CHARACTER_RESURRECTION = 206,
        ACTION_COLLECT_RESOURCE = 207,
        ACTION_DECORS_PLAY_ANIMATION = 208,
        ACTION_CHARACTER_INVENTORY_ADD_ITEM_NOCHECK = 209,
        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PERCENT = 210,
        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PERCENT = 211,
        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PERCENT = 212,
        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PERCENT = 213,
        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PERCENT = 214,
        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PERCENT = 215,
        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PERCENT = 216,
        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PERCENT = 217,
        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PERCENT = 218,
        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PERCENT = 219,
        ACTION_CHARACTER_REFLECTOR_UNBOOSTED = 220,
        ACTION_CHARACTER_INVENTORY_ADD_ITEM_RANDOM_NOCHECK = 221,
        ACTION_CHARACTER_INVENTORY_ADD_ITEM_FROM_RANDOM_DROP = 222,
        ACTION_DECORS_OBSTACLE_CLOSE_RANDOM = 223,
        ACTION_DECORS_OBSTACLE_OPEN_RANDOM = 224,
        ACTION_CHARACTER_BOOST_TRAP = 225,
        ACTION_CHARACTER_BOOST_TRAP_PERCENT = 226,
        ACTION_DECORS_PLAY_ANIMATION_UNLIGHTED = 228,
        ACTION_CHARACTER_GAIN_RIDE = 229,
        ACTION_CHARACTER_ENERGY_LOSS_BOOST = 230,
        ACTION_CHARACTER_ENERGY_POINTS_LOOSE = 231,
        ACTION_CHARACTER_INVENTORY_ADD_ITEM_ON_RP_MAP = 232,
        ACTION_CHARACTER_INVENTORY_REMOVE_ITEM_ON_RP_MAP = 233,
        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_RESIST = 240,
        ACTION_CHARACTER_BOOST_WATER_ELEMENT_RESIST = 241,
        ACTION_CHARACTER_BOOST_AIR_ELEMENT_RESIST = 242,
        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_RESIST = 243,
        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_RESIST = 244,
        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_RESIST = 245,
        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_RESIST = 246,
        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_RESIST = 247,
        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_RESIST = 248,
        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_RESIST = 249,
        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_PERCENT = 250,
        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_PERCENT = 251,
        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_PERCENT = 252,
        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_PERCENT = 253,
        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_PERCENT = 254,
        ACTION_CHARACTER_DEBOOST_EARTH_ELEMENT_PVP_PERCENT = 255,
        ACTION_CHARACTER_DEBOOST_WATER_ELEMENT_PVP_PERCENT = 256,
        ACTION_CHARACTER_DEBOOST_AIR_ELEMENT_PVP_PERCENT = 257,
        ACTION_CHARACTER_DEBOOST_FIRE_ELEMENT_PVP_PERCENT = 258,
        ACTION_CHARACTER_DEBOOST_NEUTRAL_ELEMENT_PVP_PERCENT = 259,
        ACTION_CHARACTER_BOOST_EARTH_ELEMENT_PVP_RESIST = 260,
        ACTION_CHARACTER_BOOST_WATER_ELEMENT_PVP_RESIST = 261,
        ACTION_CHARACTER_BOOST_AIR_ELEMENT_PVP_RESIST = 262,
        ACTION_CHARACTER_BOOST_FIRE_ELEMENT_PVP_RESIST = 263,
        ACTION_CHARACTER_BOOST_NEUTRAL_ELEMENT_PVP_RESIST = 264,
        ACTION_CHARACTER_LIFE_LOST_CASTER_MODERATOR = 265,
        ACTION_CHARACTER_STEAL_CHANCE = 266,
        ACTION_CHARACTER_STEAL_VITALITY = 267,
        ACTION_CHARACTER_STEAL_AGILITY = 268,
        ACTION_CHARACTER_STEAL_INTELLIGENCE = 269,
        ACTION_CHARACTER_STEAL_WISDOM = 270,
        ACTION_CHARACTER_STEAL_STRENGTH = 271,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_WATER = 275,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_EARTH = 276,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_AIR = 277,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING_FROM_FIRE = 278,
        ACTION_CHARACTER_LIFE_POINTS_LOST_BASED_ON_CASTER_LIFE_MISSING = 279,
        ACTION_BOOST_SPELL_RANGE = 281,
        ACTION_BOOST_SPELL_RANGEABLE = 282,
        ACTION_BOOST_SPELL_DMG = 283,
        ACTION_BOOST_SPELL_HEAL = 284,
        ACTION_BOOST_SPELL_AP_COST = 285,
        ACTION_BOOST_SPELL_CAST_INTVL = 286,
        ACTION_BOOST_SPELL_CC = 287,
        ACTION_BOOST_SPELL_CASTOUTLINE = 288,
        ACTION_BOOST_SPELL_NOLINEOFSIGHT = 289,
        ACTION_BOOST_SPELL_MAXPERTURN = 290,
        ACTION_BOOST_SPELL_MAXPERTARGET = 291,
        ACTION_BOOST_SPELL_CAST_INTVL_SET = 292,
        ACTION_BOOST_SPELL_BASE_DMG = 293,
        ACTION_DEBOOST_SPELL_RANGE = 294,
        ACTION_FIGHT_CAST_SPELL = 300,
        ACTION_FIGHT_CAST_SPELL_CRITICAL_HIT = 301,
        ACTION_FIGHT_CAST_SPELL_CRITICAL_MISS = 302,
        ACTION_FIGHT_CLOSE_COMBAT = 303,
        ACTION_FIGHT_CLOSE_COMBAT_CRITICAL_HIT = 304,
        ACTION_FIGHT_CLOSE_COMBAT_CRITICAL_MISS = 305,
        ACTION_FIGHT_TRIGGER_TRAP = 306,
        ACTION_FIGHT_TRIGGER_GLYPH = 307,
        ACTION_FIGHT_SPELL_DODGED_PA = 308,
        ACTION_FIGHT_SPELL_DODGED_PM = 309,
        ACTION_CHARACTER_STEAL_RANGE = 320,
        ACTION_CHARACTER_CHANGE_COLOR = 333,
        ACTION_CHARACTER_ADD_APPEARANCE = 335,
        ACTION_FIGHT_ADD_TRAP_CASTING_SPELL = 400,
        ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL = 401,
        ACTION_FIGHT_ADD_GLYPH_CASTING_SPELL_ENDTURN = 402,
        ACTION_FIGHT_KILL_AND_SUMMON = 405,
        ACTION_INTERACTIVE_ELEMENT = 500,
        ACTION_SKILL_ANIMATION = 501,
        ACTION_EXCHANGE_CRAFT_OPEN = 502,
        ACTION_USE_WAYPOINT = 503,
        ACTION_DO_ELEMENT_PARAMETERIZED_OPERATION = 505,
        ACTION_INTERACTIVE_ELEMENT_AT_HOME_INNER_DOOR = 507,
        ACTION_SAVE_WAYPOINT = 508,
        ACTION_CHANGE_COMPASS = 509,
        ACTION_USE_SUBWAY = 510,
        ACTION_EXCHANGE_JOBINDEX_OPEN = 511,
        ACTION_USE_PRISM = 512,
        ACTION_ADD_PRISM = 513,
        ACTION_CHARACTER_BOOST_DISPELLED = 514,
        ACTION_CHARACTER_UPDATE_BOOST = 515,
        ACTION_GOTO_WAYPOINT = 600,
        ACTION_GOTO_MAP = 601,
        ACTION_CHARACTER_LEARN_JOB = 603,
        ACTION_CHARACTER_LEARN_SPELL = 604,
        ACTION_CHARACTER_GAIN_XP = 605,
        ACTION_CHARACTER_GAIN_WISDOM = 606,
        ACTION_CHARACTER_GAIN_STRENGTH = 607,
        ACTION_CHARACTER_GAIN_CHANCE = 608,
        ACTION_CHARACTER_GAIN_AGILITY = 609,
        ACTION_CHARACTER_GAIN_VITALITY = 610,
        ACTION_CHARACTER_GAIN_INTELLIGENCE = 611,
        ACTION_CHARACTER_GAIN_STATS_POINTS = 612,
        ACTION_CHARACTER_GAIN_SPELL_POINTS = 613,
        ACTION_CHARACTER_GAIN_JOB_XP = 614,
        ACTION_CHARACTER_UNLEARN_JOB = 615,
        ACTION_CHARACTER_UNBOOST_SPELL = 616,
        ACTION_CHARACTER_GET_MARRIED = 617,
        ACTION_CHARACTER_GET_MARRIED_ACCEPT = 618,
        ACTION_CHARACTER_GET_MARRIED_DECLINE = 619,
        ACTION_CHARACTER_READ_BOOK = 620,
        ACTION_CHARACTER_SUMMON_MONSTER = 621,
        ACTION_GOTO_HOUSE = 622,
        ACTION_CHARACTER_SUMMON_MONSTER_GROUP = 623,
        ACTION_CHARACTER_UNLEARN_GUILDSPELL = 624,
        ACTION_CHARACTER_UNBOOST_CARACS = 625,
        ACTION_CHARACTER_UNBOOST_CARACS_TO_101 = 626,
        ACTION_CHARACTER_SUMMON_MONSTER_GROUP_SET_MAP = 627,
        ACTION_CHARACTER_SUMMON_MONSTER_GROUP_DYNAMIC = 628,
        ACTION_CHARACTER_SEND_INFORMATION_TEXT = 630,
        ACTION_CHARACTER_SEND_DIALOG_ACTION = 631,
        ACTION_CHARACTER_GAIN_HONOUR = 640,
        ACTION_CHARACTER_GAIN_DISHONOUR = 641,
        ACTION_CHARACTER_LOOSE_HONOUR = 642,
        ACTION_CHARACTER_LOOSE_DISHONOUR = 643,
        ACTION_MAP_RESURECTION_ALLIES = 645,
        ACTION_MAP_HEAL_ALLIES = 646,
        ACTION_MAP_FORCE_ENNEMIES_GHOST = 647,
        ACTION_FORCE_ENNEMY_GHOST = 648,
        ACTION_FAKE_ALIGNMENT = 649,
        ACTION_TELEPORT_NOOBY_MAP = 650,
        ACTION_USE_ELEMENT_ACTIONS = 651,
        ACTION_SET_STATED_ELEMENT_STATE = 652,
        ACTION_RESET_STATED_ELEMENT = 653,
        ACTION_HOUSE_LEAVE = 654,
        ACTION_NOOP = 666,
        ACTION_INCARNATION = 669,
        ACTION_CHARACTER_REFERENCEMENT = 699,
        ACTION_ITEM_CHANGE_EFFECT = 700,
        ACTION_ITEM_ADD_EFFECT = 701,
        ACTION_ITEM_ADD_DURABILITY = 702,
        ACTION_CAPTURE_SOUL = 705,
        ACTION_CAPTURE_RIDE = 706,
        ACTION_CHARACTER_ADD_COST_TO_ACTION = 710,
        ACTION_LADDER_SUPERRACE = 715,
        ACTION_LADDER_RACE = 716,
        ACTION_LADDER_ID = 717,
        ACTION_PVP_LADDER = 720,
        ACTION_VICTIM_OF = 721,
        ACTION_GAIN_TEMP_SPELL = 722,
        ACTION_GAIN_AURA = 723,
        ACTION_GAIN_TITLE = 724,
        ACTION_CHARACTER_RENAME_GUILD = 725,
        ACTION_TELEPORT_NEAREST_PRISM = 730,
        ACTION_AUTO_AGGRESS_ENEMY_PLAYER = 731,
        ACTION_SHUSHU_STACK_RUNE = 742,
        ACTION_BOOST_SOUL_CAPTURE_BONUS = 750,
        ACTION_BOOST_RIDE_XP_BONUS = 751,
        ACTION_CHARACTER_BOOST_DODGE = 752,
        ACTION_CHARACTER_BOOST_TACKLE = 753,
        ACTION_CHARACTER_DEBOOST_DODGE = 754,
        ACTION_CHARACTER_DEBOOST_TACKLE = 755,
        ACTION_REMOVE_ON_MOVE = 760,
        ACTION_CHARACTER_SACRIFY = 765,
        ACTION_HOURLY_CONFUSION_DEGREE = 770,
        ACTION_HOURLY_CONFUSION_PI_2 = 771,
        ACTION_HOURLY_CONFUSION_PI_4 = 772,
        ACTION_UNHOURLY_CONFUSION_DEGREE = 773,
        ACTION_UNHOURLY_CONFUSION_PI_2 = 774,
        ACTION_UNHOURLY_CONFUSION_PI_4 = 775,
        ACTION_CHARACTER_BOOST_PERMANENT_DAMAGE_PERCENT = 776,
        ACTION_CHARACTER_SUMMON_DEAD_ALLY_IN_FIGHT = 780,
        ACTION_CHARACTER_UNLUCKY = 781,
        ACTION_CHARACTER_MAXIMIZE_ROLL = 782,
        ACTION_CHARACTER_WALK_FOUR_DIR = 785,
        ACTION_FIND_BOUNTY_TARGET = 790,
        ACTION_MARK_TARGET_MERCENARY = 791,
        ACTION_ITEM_CHANGE_PETS_LIFE = 800,
        ACTION_ITEM_CHANGE_DURATION = 805,
        ACTION_ITEM_PETS_SHAPE = 806,
        ACTION_ITEM_PETS_EAT = 807,
        ACTION_PETS_LAST_MEAL = 808,
        ACTION_ITEM_CHANGE_DURABILITY = 812,
        ACTION_ITEM_UPDATE_DATE = 813,
        ACTION_ITEM_CHOOSE_IN_ITEM_LIST = 820,
        ACTION_CLIENT_OPEN_UI = 830,
        ACTION_CLIENT_OPEN_UI_SPELL_FORGET = 831,
        ACTION_FIGHT_TURN_FINISHED = 899,
        ACTION_FIGHT_CHALLENGE = 900,
        ACTION_FIGHT_CHALLENGE_ACCEPT = 901,
        ACTION_FIGHT_CHALLENGE_DECLINE = 902,
        ACTION_FIGHT_CHALLENGE_JOIN = 903,
        ACTION_FIGHT_CHALLENGE_AGAINST_MONSTER = 905,
        ACTION_FIGHT_AGGRESSION = 906,
        ACTION_FIGHT_AGAINST_TAXCOLLECTOR = 909,
        ACTION_FIGHT_CHALLENGE_AGAINST_MUTANT = 910,
        ACTION_FIGHT_CHALLENGE_MIXED_VERSUS_MONSTER = 911,
        ACTION_FIGHT_AGAINST_PRISM = 912,
        ACTION_TOOLTIP_ACTIVATE_TIP = 915,
        ACTION_PNJ_REMOVE_RIDE = 938,
        ACTION_PET_SET_POWER_BOOST = 939,
        ACTION_FARM_WITHDRAW_ITEM = 947,
        ACTION_FARM_PLACE_ITEM = 948,
        ACTION_MOUNT_RIDE = 949,
        ACTION_FIGHT_SET_STATE = 950,
        ACTION_FIGHT_UNSET_STATE = 951,
        ACTION_CREATED_SINCE = 963,
        ACTION_SHOW_PLAYERNAME = 964,
        ACTION_ENCAPSULATE_BINARY_COMMAND = 993,
        ACTION_CHARACTER_ADD_SPELL_COOLDOWN = 1035,
        ACTION_CHARACTER_REMOVE_SPELL_COOLDOWN = 1036,
        ACTION_CHARACTER_BOOST_SHIELD_BASED_ON_CASTER_LIFE = 1039,
        ACTION_CHARACTER_BOOST_SHIELD = 1040,
        ACTION_CHARACTER_LIFE_POINTS_MALUS = 1047,
        ACTION_CHARACTER_LIFE_POINTS_MALUS_PERCENT = 1048,
        ACTION_CHARACTER_MODIFY_DURATION_EFFECT = 1075,
        ACTION_BOOST_GLOBAL_RESISTS_BONUS = 1076,
        ACTION_BOOST_GLOBAL_RESISTS_MALUS = 1077
    }
}