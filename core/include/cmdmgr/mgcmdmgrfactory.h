//! \file mgcmdmgrfactory.h
//! \brief 定义命令管理器的创建类 MgCmdManagerFactory
// Copyright (c) 2004-2013, Zhang Yungui
// License: LGPL, https://github.com/rhcad/touchvg

#ifndef TOUCHVG_CMDMGR_FACTORY_H_
#define TOUCHVG_CMDMGR_FACTORY_H_

struct MgCmdManager;

//! 命令管理器的创建类
/*! \ingroup CORE_COMMAND
*/
class MgCmdManagerFactory {
public:
    //! 创建命令管理器
	static MgCmdManager* create();
};

#endif // TOUCHVG_CMDMGR_FACTORY_H_
