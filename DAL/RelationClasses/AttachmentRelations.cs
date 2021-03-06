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
	/// <summary>Implements the relations factory for the entity: Attachment. </summary>
	public partial class AttachmentRelations
	{
		/// <summary>CTor</summary>
		public AttachmentRelations()
		{
		}

		/// <summary>Gets all relations of the AttachmentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.MessageEntityUsingMessageID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AttachmentEntity and MessageEntity over the m:1 relation they have, using the relation between the fields:
		/// Attachment.MessageID - Message.MessageID
		/// </summary>
		public virtual IEntityRelation MessageEntityUsingMessageID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BelongsToMessage", false);
				relation.AddEntityFieldPair(MessageFields.MessageID, AttachmentFields.MessageID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MessageEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AttachmentEntity", true);
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
	internal static class StaticAttachmentRelations
	{
		internal static readonly IEntityRelation MessageEntityUsingMessageIDStatic = new AttachmentRelations().MessageEntityUsingMessageID;

		/// <summary>CTor</summary>
		static StaticAttachmentRelations()
		{
		}
	}
}
