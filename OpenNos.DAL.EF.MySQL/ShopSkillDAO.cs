﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using AutoMapper;

using OpenNos.DAL.EF.MySQL.Helpers;
using OpenNos.DAL.Interface;
using OpenNos.Data;
using System.Collections.Generic;
using System.Linq;

namespace OpenNos.DAL.EF.MySQL
{
    public class ShopSkillDAO : IShopSkillDAO
    {
        #region Private Members

        private IMapper _mapper;

        #endregion

        #region Public Instantiation

        public ShopSkillDAO()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ShopSkill, ShopSkillDTO>();
                cfg.CreateMap<ShopSkillDTO, ShopSkill>();
            });

            _mapper = config.CreateMapper();
        }

        #endregion

        #region Public Methods

        public ShopSkillDTO Insert(ShopSkillDTO shopSkill)
        {
            using (var context = DataAccessHelper.CreateContext())
            {
                ShopSkill entity = _mapper.Map<ShopSkill>(shopSkill);
                context.ShopSkill.Add(entity);
                context.SaveChanges();
                return _mapper.Map<ShopSkillDTO>(entity);
            }
        }

        public void Insert(List<ShopSkillDTO> skills)
        {
            using (var context = DataAccessHelper.CreateContext())
            {
                context.Configuration.AutoDetectChangesEnabled = false;
                foreach (ShopSkillDTO Skill in skills)
                {
                    ShopSkill entity = _mapper.Map<ShopSkill>(Skill);
                    context.ShopSkill.Add(entity);
                }
                context.SaveChanges();
            }
        }

        public IEnumerable<ShopSkillDTO> LoadByShopId(int shopId)
        {
            using (var context = DataAccessHelper.CreateContext())
            {
                foreach (ShopSkill ShopSkill in context.ShopSkill.Where(s => s.ShopId.Equals(shopId)))
                {
                    yield return _mapper.Map<ShopSkillDTO>(ShopSkill);
                }
            }
        }

        #endregion
    }
}