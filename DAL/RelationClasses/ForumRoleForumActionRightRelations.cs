﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SD.HnD.DAL;
using SD.HnD.DAL.FactoryClasses;
using SD.HnD.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.HnD.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ForumRoleForumActionRight. </summary>
	public partial class ForumRoleForumActionRightRelations
	{
		/// <summary>CTor</summary>
		public ForumRoleForumActionRightRelations()
		{
		}

		/// <summary>Gets all relations of the ForumRoleForumActionRightEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ActionRightEntityUsingActionRightID);
			toReturn.Add(this.ForumEntityUsingForumID);
			toReturn.Add(this.RoleEntityUsingRoleID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ForumRoleForumActionRightEntity and ActionRightEntity over the m:1 relation they have, using the relation between the fields:
		/// ForumRoleForumActionRight.ActionRightID - ActionRight.ActionRightID
		/// </summary>
		public virtual IEntityRelation ActionRightEntityUsingActionRightID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ActionRight", false);
				relation.AddEntityFieldPair(ActionRightFields.ActionRightID, ForumRoleForumActionRightFields.ActionRightID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ActionRightEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ForumRoleForumActionRightEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ForumRoleForumActionRightEntity and ForumEntity over the m:1 relation they have, using the relation between the fields:
		/// ForumRoleForumActionRight.ForumID - Forum.ForumID
		/// </summary>
		public virtual IEntityRelation ForumEntityUsingForumID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Forum", false);
				relation.AddEntityFieldPair(ForumFields.ForumID, ForumRoleForumActionRightFields.ForumID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ForumEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ForumRoleForumActionRightEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ForumRoleForumActionRightEntity and RoleEntity over the m:1 relation they have, using the relation between the fields:
		/// ForumRoleForumActionRight.RoleID - Role.RoleID
		/// </summary>
		public virtual IEntityRelation RoleEntityUsingRoleID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Role", false);
				relation.AddEntityFieldPair(RoleFields.RoleID, ForumRoleForumActionRightFields.RoleID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RoleEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ForumRoleForumActionRightEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticForumRoleForumActionRightRelations
	{
		internal static readonly IEntityRelation ActionRightEntityUsingActionRightIDStatic = new ForumRoleForumActionRightRelations().ActionRightEntityUsingActionRightID;
		internal static readonly IEntityRelation ForumEntityUsingForumIDStatic = new ForumRoleForumActionRightRelations().ForumEntityUsingForumID;
		internal static readonly IEntityRelation RoleEntityUsingRoleIDStatic = new ForumRoleForumActionRightRelations().RoleEntityUsingRoleID;

		/// <summary>CTor</summary>
		static StaticForumRoleForumActionRightRelations()
		{
		}
	}
}
