﻿using System;
namespace Shop.Model
{
	[Serializable]
	public class Lebi_Agent_User
	{
		#region Model
		private int _id=0;
		private int _user_id=0;
		private decimal _angent1_commission=0;
		private decimal _angent2_commission=0;
		private decimal _angent3_commission=0;
		private Lebi_Agent_User _model;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int User_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Angent1_Commission
		{
			set{ _angent1_commission=value;}
			get{return _angent1_commission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Angent2_Commission
		{
			set{ _angent2_commission=value;}
			get{return _angent2_commission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Angent3_Commission
		{
			set{ _angent3_commission=value;}
			get{return _angent3_commission;}
		}
		#endregion

	}
}

