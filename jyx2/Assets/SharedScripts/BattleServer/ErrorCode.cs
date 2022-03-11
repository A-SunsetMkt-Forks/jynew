﻿namespace Jyx2.SharedScripts.BattleServer
{
    /// <summary>
    /// 战斗服务器通信错误码
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 正常
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// 房间已满
        /// </summary>
        RoomIsFull = 10001,
        
        /// <summary>
        /// 指定ID的房间不存在
        /// </summary>
        RoomIsNotExist = 10002,
        
    }
}