﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : StyleSheets.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet StyleSheets
// Créé le       : 01/03/2015
// Modifié le    : 11/05/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Windows;
using System.IO.IsolatedStorage;
using System.Windows.Phone.Infos;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using NextRadio.Service.Resources;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextRadio.Service"
//*******************************************************************************************************************************
namespace NextRadio.Service
	{

    //   ####  #####  #   #  #      #####          ####  #   #  #####  #####  #####   ####
    //  #        #     # #   #      #             #      #   #  #      #        #    #    
    //   ###     #      #    #      ###    #####   ###   #####  ###    ###      #     ### 
    //      #    #      #    #      #                 #  #   #  #      #        #        #
    //  ####     #      #    #####  #####         ####   #   #  #####  #####    #    #### 
	
	//***************************************************************************************************************************
	// Classe StyleSheets
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Gestion du thème de l'app.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public static class StyleSheets
		{
		//-----------------------------------------------------------------------------------------------------------------------
		// Section des Attributs
		//-----------------------------------------------------------------------------------------------------------------------
		private static string ContentBuffer = string.Empty;
		//-----------------------------------------------------------------------------------------------------------------------

		//***********************************************************************************************************************
		/// <summary>
		/// Génère les styles.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		private static string Generate ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			#region // Implémentation de la Procédure
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			try
				{
				//---------------------------------------------------------------------------------------------------------------
				AppTheme CurrentTheme = StyleSheets.Theme;

				string BodyBackColor = ( CurrentTheme == AppTheme.Dark ) ? "151515" : "EAEAEA";
				string BodyForeColor = ( CurrentTheme == AppTheme.Dark ) ? "FFF"    : "000";
				string BodyGrayColor = ( CurrentTheme == AppTheme.Dark ) ? "AAA"    : "444";
				string DateBackColor = ( CurrentTheme == AppTheme.Dark ) ? "A0A0A0" : "303030";
				string DateForeColor = ( CurrentTheme == AppTheme.Dark ) ? "000"    : "FFF";
				string SepaBackColor = ( CurrentTheme == AppTheme.Dark ) ? "999999" : "999999";
				string LinkForeColor = ( CurrentTheme == AppTheme.Dark ) ? "FFF"    : "0000EE";

				string Content = string.Empty;
				
				using ( StringReader Sr = new StringReader ( SR.GetResource ( "Global", "Cont.css" ) ) )
					{
					string Line;

					while ( ( Line = Sr.ReadLine () ) != null )
						{
						if ( Line.StartsWith ( "/" ) ) continue;
						if ( Line.Length        == 0 ) continue;

						Content += Line;
						}
					}
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				switch ( StyleSheets.TextLevel )
					{
					//-----------------------------------------------------------------------------------------------------------
					case TextLevel.Small : return string.Format ( Content                ,
					                                              BodyBackColor          ,
																  BodyForeColor          ,
																  BodyGrayColor          ,
																  DateBackColor          ,
																  DateForeColor          ,
																  SepaBackColor          ,
																  LinkForeColor          ,

																  14, 16, 10, 12         , 
																  18, 20, 10, 12, 14, 16 ,
																  18, 20, 12, 14         );
					//-----------------------------------------------------------------------------------------------------------
					case TextLevel.Large : return string.Format ( Content                ,
					                                              BodyBackColor          ,
																  BodyForeColor          ,
																  BodyGrayColor          ,
																  DateBackColor          ,
																  DateForeColor          ,
																  SepaBackColor          ,
																  LinkForeColor          ,

																  20, 22, 16, 18         , 
																  24, 26, 16, 18, 20, 22 ,
																  24, 26, 18, 20         );
					//-----------------------------------------------------------------------------------------------------------
					default              : return string.Format ( Content                ,
					                                              BodyBackColor          ,
																  BodyForeColor          ,
																  BodyGrayColor          ,
																  DateBackColor          ,
																  DateForeColor          ,
																  SepaBackColor          ,
																  LinkForeColor          ,

																  16, 18, 12, 14         , 
																  20, 22, 12, 14, 16, 18 ,
																  20, 22, 14, 16         );
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			return string.Empty;
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			#endregion
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
		/// <summary>
		/// Vide les styles.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static void Clear () { StyleSheets.ContentBuffer = string.Empty; }
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
		#region // >> Content
		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Obtiens les styles courants.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static string Content
			{
			//-------------------------------------------------------------------------------------------------------------------
			get
				{
				//---------------------------------------------------------------------------------------------------------------
				if ( string.IsNullOrEmpty ( StyleSheets.ContentBuffer ) )
					StyleSheets.ContentBuffer = StyleSheets.Generate ();

				return StyleSheets.ContentBuffer;
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//-----------------------------------------------------------------------------------------------------------------------
		#endregion
		//***********************************************************************************************************************
		
		//***********************************************************************************************************************
		#region // >> TextLevel
		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Obtiens ou définit le niveau du texte.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static TextLevel TextLevel
			{
			//-------------------------------------------------------------------------------------------------------------------
			get
				{
				//---------------------------------------------------------------------------------------------------------------
				object textLevel = StorageSettings.GetValue ( "text-level" );

				try
					{
					if ( textLevel == null || ! ( textLevel is int ) )
						{
						textLevel = ( DeviceInfos.DeviceType == DeviceType.SmartPhone ) ? TextLevel.Medium : TextLevel.Small;

						StorageSettings.SetValue ( "text-level", (int)textLevel );
						}
					}
				catch {}
				
				return (TextLevel)textLevel;
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			set
				{
				//---------------------------------------------------------------------------------------------------------------
				if ( value != StyleSheets.TextLevel )
					{
					//-----------------------------------------------------------------------------------------------------------
					StorageSettings.SetValue ( "text-level", (int)value );

					StyleSheets.ContentBuffer = string.Empty;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//-----------------------------------------------------------------------------------------------------------------------
		#endregion
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		#region // >> Theme
		//-----------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Obtiens ou définit le thème courant.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static AppTheme Theme
			{
			//-------------------------------------------------------------------------------------------------------------------
			get
				{
				//---------------------------------------------------------------------------------------------------------------
				object Theme = StorageSettings.GetValue ( "app-theme" );

				try
					{
					if ( Theme == null || ! ( Theme is int ) )
						{
						Visibility PhoneLightThemeVisibility = (Visibility)Application.Current.
						                                    Resources["PhoneLightThemeVisibility"];

						Theme = ( PhoneLightThemeVisibility == Visibility.Visible ) ? AppTheme.Light : AppTheme.Dark;

						StorageSettings.SetValue ( "app-theme", (int)Theme );
						}
					}
				catch { Theme = AppTheme.Light; }
				
				return (AppTheme)Theme;
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			set
				{
				//---------------------------------------------------------------------------------------------------------------
				if ( value != StyleSheets.Theme )
					{
					//-----------------------------------------------------------------------------------------------------------
					StorageSettings.SetValue ( "app-theme", (int)value );

					StyleSheets.ContentBuffer = string.Empty;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//-----------------------------------------------------------------------------------------------------------------------
		#endregion
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextRadio.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************