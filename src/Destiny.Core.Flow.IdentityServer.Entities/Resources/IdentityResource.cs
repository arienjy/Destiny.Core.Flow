﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Destiny.Core.Flow.Entity;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// 身份资源
    /// </summary>
    public class IdentityResource : IEntity<Guid>, ICreatedTime, IModificationTime
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [Description("是否启用")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [Description("显示名称")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Description("描述")]
        public string Description { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        [Description("是否必须")]
        public bool Required { get; set; }

        /// <summary>
        /// 是否强调显示
        /// </summary>
        [Description("是否强调显示")]
        public bool Emphasize { get; set; }

        /// <summary>
        /// 是否显示在发现文档中
        /// </summary>
        [Description("是否显示在发现文档中")]
        public bool ShowInDiscoveryDocument { get; set; }

        /// <summary>
        /// 用户声明
        /// </summary>
        [Description("用户声明")]
        public List<IdentityResourceClaim> UserClaims { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [Description("属性")]
        public List<IdentityResourceProperty> Properties { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DisplayName("更新时间")]
        public DateTime? LastModifionTime { get; set; }

        /// <summary>
        /// 是否不可编辑
        /// </summary>
        [Description("是否不可编辑")]
        public bool NonEditable { get; set; }
    }
}