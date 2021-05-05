using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;
using System;
using System.Collections.Generic;

namespace SB.TelegramBot.Logics.TelegramBotCommands.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCommandFactory
    {
        /// <summary>
        /// 
        /// </summary>
        void Initialize();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void IgnoreCommand<T>() where T : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCommandInstance(TelegramBotCommandInfo info);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TelegramBotCommandInfo> GetCommands();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        TelegramBotCommandInfo GetBackCommandHandler(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandId"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCallbackCommand(long commandId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCallbackCommand(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCallbackCommandByClrName(string clrName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandType"></param>
        /// <returns></returns>
        TelegramBotCommandInfo GetCommandInfo(Type commandType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        TelegramBotCommandInfo GetCommandInfoByClrName(string clrName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCommand(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        ITelegramBotCommand GetCommandByClrName(string clrName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITelegramBotCommand GetInternalCommand(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        ITelegramBotCommand GetInternalCommandByClrName(string clrName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITelegramBotCommand GetPublicOrInternalCommand(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        ITelegramBotCommand GetPublicOrInternalCommandByClrName(string clrName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        TelegramBotCommandInfo GetPublicCommandInfo(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        TelegramBotCommandInfo GetPublicCommandInfo(string name, string role);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        ITelegramBotCommand GetPublicCommand(string name, string role);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ITelegramBotCommand GetPublicCommand(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clrName"></param>
        /// <returns></returns>
        ITelegramBotCommand GetPublicCommandByClrName(string clrName);
    }
}
