﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ReportingModel", "AreaRegion", "Area", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(npc.reporting.repositories.Area), "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(npc.reporting.repositories.Region))]
[assembly: EdmRelationshipAttribute("ReportingModel", "RegionPlant", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(npc.reporting.repositories.Region), "Plant", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(npc.reporting.repositories.Plant))]
[assembly: EdmRelationshipAttribute("ReportingModel", "PlantData", "Plant", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(npc.reporting.repositories.Plant), "Data", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(npc.reporting.repositories.Data))]

#endregion

namespace npc.reporting.repositories
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ReportingModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ReportingModelContainer object using the connection string found in the 'ReportingModelContainer' section of the application configuration file.
        /// </summary>
        public ReportingModelContainer() : base("name=ReportingModelContainer", "ReportingModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReportingModelContainer object.
        /// </summary>
        public ReportingModelContainer(string connectionString) : base(connectionString, "ReportingModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReportingModelContainer object.
        /// </summary>
        public ReportingModelContainer(EntityConnection connection) : base(connection, "ReportingModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Area> Areas
        {
            get
            {
                if ((_Areas == null))
                {
                    _Areas = base.CreateObjectSet<Area>("Areas");
                }
                return _Areas;
            }
        }
        private ObjectSet<Area> _Areas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Region> Regions
        {
            get
            {
                if ((_Regions == null))
                {
                    _Regions = base.CreateObjectSet<Region>("Regions");
                }
                return _Regions;
            }
        }
        private ObjectSet<Region> _Regions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Plant> Plants
        {
            get
            {
                if ((_Plants == null))
                {
                    _Plants = base.CreateObjectSet<Plant>("Plants");
                }
                return _Plants;
            }
        }
        private ObjectSet<Plant> _Plants;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Data> Data
        {
            get
            {
                if ((_Data == null))
                {
                    _Data = base.CreateObjectSet<Data>("Data");
                }
                return _Data;
            }
        }
        private ObjectSet<Data> _Data;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Areas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAreas(Area area)
        {
            base.AddObject("Areas", area);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Regions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegions(Region region)
        {
            base.AddObject("Regions", region);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Plants EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPlants(Plant plant)
        {
            base.AddObject("Plants", plant);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Data EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToData(Data data)
        {
            base.AddObject("Data", data);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReportingModel", Name="Area")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Area : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Area object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="areaName">Initial value of the areaName property.</param>
        public static Area CreateArea(global::System.Int32 id, global::System.String areaName)
        {
            Area area = new Area();
            area.Id = id;
            area.areaName = areaName;
            return area;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String areaName
        {
            get
            {
                return _areaName;
            }
            set
            {
                OnareaNameChanging(value);
                ReportPropertyChanging("areaName");
                _areaName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("areaName");
                OnareaNameChanged();
            }
        }
        private global::System.String _areaName;
        partial void OnareaNameChanging(global::System.String value);
        partial void OnareaNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "AreaRegion", "Region")]
        public EntityCollection<Region> Regions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Region>("ReportingModel.AreaRegion", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Region>("ReportingModel.AreaRegion", "Region", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReportingModel", Name="Data")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Data : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Data object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="d2008">Initial value of the d2008 property.</param>
        /// <param name="d2009">Initial value of the d2009 property.</param>
        /// <param name="d2010">Initial value of the d2010 property.</param>
        /// <param name="d2011">Initial value of the d2011 property.</param>
        /// <param name="d2012">Initial value of the d2012 property.</param>
        /// <param name="d2013">Initial value of the d2013 property.</param>
        /// <param name="d2014">Initial value of the d2014 property.</param>
        /// <param name="d2015">Initial value of the d2015 property.</param>
        /// <param name="d2016">Initial value of the d2016 property.</param>
        /// <param name="d2017">Initial value of the d2017 property.</param>
        /// <param name="d2018">Initial value of the d2018 property.</param>
        /// <param name="d2019">Initial value of the d2019 property.</param>
        /// <param name="d2020">Initial value of the d2020 property.</param>
        /// <param name="d2021">Initial value of the d2021 property.</param>
        /// <param name="d2022">Initial value of the d2022 property.</param>
        public static Data CreateData(global::System.Int32 id, global::System.Double d2008, global::System.Double d2009, global::System.Double d2010, global::System.Double d2011, global::System.Double d2012, global::System.Double d2013, global::System.Double d2014, global::System.Double d2015, global::System.Double d2016, global::System.Double d2017, global::System.Double d2018, global::System.Double d2019, global::System.Double d2020, global::System.Double d2021, global::System.Double d2022)
        {
            Data data = new Data();
            data.Id = id;
            data.d2008 = d2008;
            data.d2009 = d2009;
            data.d2010 = d2010;
            data.d2011 = d2011;
            data.d2012 = d2012;
            data.d2013 = d2013;
            data.d2014 = d2014;
            data.d2015 = d2015;
            data.d2016 = d2016;
            data.d2017 = d2017;
            data.d2018 = d2018;
            data.d2019 = d2019;
            data.d2020 = d2020;
            data.d2021 = d2021;
            data.d2022 = d2022;
            return data;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2008
        {
            get
            {
                return _d2008;
            }
            set
            {
                Ond2008Changing(value);
                ReportPropertyChanging("d2008");
                _d2008 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2008");
                Ond2008Changed();
            }
        }
        private global::System.Double _d2008;
        partial void Ond2008Changing(global::System.Double value);
        partial void Ond2008Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2009
        {
            get
            {
                return _d2009;
            }
            set
            {
                Ond2009Changing(value);
                ReportPropertyChanging("d2009");
                _d2009 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2009");
                Ond2009Changed();
            }
        }
        private global::System.Double _d2009;
        partial void Ond2009Changing(global::System.Double value);
        partial void Ond2009Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2010
        {
            get
            {
                return _d2010;
            }
            set
            {
                Ond2010Changing(value);
                ReportPropertyChanging("d2010");
                _d2010 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2010");
                Ond2010Changed();
            }
        }
        private global::System.Double _d2010;
        partial void Ond2010Changing(global::System.Double value);
        partial void Ond2010Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2011
        {
            get
            {
                return _d2011;
            }
            set
            {
                Ond2011Changing(value);
                ReportPropertyChanging("d2011");
                _d2011 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2011");
                Ond2011Changed();
            }
        }
        private global::System.Double _d2011;
        partial void Ond2011Changing(global::System.Double value);
        partial void Ond2011Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2012
        {
            get
            {
                return _d2012;
            }
            set
            {
                Ond2012Changing(value);
                ReportPropertyChanging("d2012");
                _d2012 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2012");
                Ond2012Changed();
            }
        }
        private global::System.Double _d2012;
        partial void Ond2012Changing(global::System.Double value);
        partial void Ond2012Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2013
        {
            get
            {
                return _d2013;
            }
            set
            {
                Ond2013Changing(value);
                ReportPropertyChanging("d2013");
                _d2013 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2013");
                Ond2013Changed();
            }
        }
        private global::System.Double _d2013;
        partial void Ond2013Changing(global::System.Double value);
        partial void Ond2013Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2014
        {
            get
            {
                return _d2014;
            }
            set
            {
                Ond2014Changing(value);
                ReportPropertyChanging("d2014");
                _d2014 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2014");
                Ond2014Changed();
            }
        }
        private global::System.Double _d2014;
        partial void Ond2014Changing(global::System.Double value);
        partial void Ond2014Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2015
        {
            get
            {
                return _d2015;
            }
            set
            {
                Ond2015Changing(value);
                ReportPropertyChanging("d2015");
                _d2015 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2015");
                Ond2015Changed();
            }
        }
        private global::System.Double _d2015;
        partial void Ond2015Changing(global::System.Double value);
        partial void Ond2015Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2016
        {
            get
            {
                return _d2016;
            }
            set
            {
                Ond2016Changing(value);
                ReportPropertyChanging("d2016");
                _d2016 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2016");
                Ond2016Changed();
            }
        }
        private global::System.Double _d2016;
        partial void Ond2016Changing(global::System.Double value);
        partial void Ond2016Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2017
        {
            get
            {
                return _d2017;
            }
            set
            {
                Ond2017Changing(value);
                ReportPropertyChanging("d2017");
                _d2017 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2017");
                Ond2017Changed();
            }
        }
        private global::System.Double _d2017;
        partial void Ond2017Changing(global::System.Double value);
        partial void Ond2017Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2018
        {
            get
            {
                return _d2018;
            }
            set
            {
                Ond2018Changing(value);
                ReportPropertyChanging("d2018");
                _d2018 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2018");
                Ond2018Changed();
            }
        }
        private global::System.Double _d2018;
        partial void Ond2018Changing(global::System.Double value);
        partial void Ond2018Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2019
        {
            get
            {
                return _d2019;
            }
            set
            {
                Ond2019Changing(value);
                ReportPropertyChanging("d2019");
                _d2019 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2019");
                Ond2019Changed();
            }
        }
        private global::System.Double _d2019;
        partial void Ond2019Changing(global::System.Double value);
        partial void Ond2019Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2020
        {
            get
            {
                return _d2020;
            }
            set
            {
                Ond2020Changing(value);
                ReportPropertyChanging("d2020");
                _d2020 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2020");
                Ond2020Changed();
            }
        }
        private global::System.Double _d2020;
        partial void Ond2020Changing(global::System.Double value);
        partial void Ond2020Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2021
        {
            get
            {
                return _d2021;
            }
            set
            {
                Ond2021Changing(value);
                ReportPropertyChanging("d2021");
                _d2021 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2021");
                Ond2021Changed();
            }
        }
        private global::System.Double _d2021;
        partial void Ond2021Changing(global::System.Double value);
        partial void Ond2021Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double d2022
        {
            get
            {
                return _d2022;
            }
            set
            {
                Ond2022Changing(value);
                ReportPropertyChanging("d2022");
                _d2022 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("d2022");
                Ond2022Changed();
            }
        }
        private global::System.Double _d2022;
        partial void Ond2022Changing(global::System.Double value);
        partial void Ond2022Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "PlantData", "Plant")]
        public Plant Plant
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Plant>("ReportingModel.PlantData", "Plant").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Plant>("ReportingModel.PlantData", "Plant").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Plant> PlantReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Plant>("ReportingModel.PlantData", "Plant");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Plant>("ReportingModel.PlantData", "Plant", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReportingModel", Name="Plant")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Plant : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Plant object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="plantName">Initial value of the plantName property.</param>
        public static Plant CreatePlant(global::System.Int32 id, global::System.String plantName)
        {
            Plant plant = new Plant();
            plant.Id = id;
            plant.plantName = plantName;
            return plant;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String plantName
        {
            get
            {
                return _plantName;
            }
            set
            {
                OnplantNameChanging(value);
                ReportPropertyChanging("plantName");
                _plantName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("plantName");
                OnplantNameChanged();
            }
        }
        private global::System.String _plantName;
        partial void OnplantNameChanging(global::System.String value);
        partial void OnplantNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "RegionPlant", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("ReportingModel.RegionPlant", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("ReportingModel.RegionPlant", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("ReportingModel.RegionPlant", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("ReportingModel.RegionPlant", "Region", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "PlantData", "Data")]
        public EntityCollection<Data> Data
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Data>("ReportingModel.PlantData", "Data");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Data>("ReportingModel.PlantData", "Data", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReportingModel", Name="Region")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Region : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Region object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="regionName">Initial value of the regionName property.</param>
        public static Region CreateRegion(global::System.Int32 id, global::System.String regionName)
        {
            Region region = new Region();
            region.Id = id;
            region.regionName = regionName;
            return region;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String regionName
        {
            get
            {
                return _regionName;
            }
            set
            {
                OnregionNameChanging(value);
                ReportPropertyChanging("regionName");
                _regionName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("regionName");
                OnregionNameChanged();
            }
        }
        private global::System.String _regionName;
        partial void OnregionNameChanging(global::System.String value);
        partial void OnregionNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "AreaRegion", "Area")]
        public Area Area
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Area>("ReportingModel.AreaRegion", "Area").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Area>("ReportingModel.AreaRegion", "Area").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Area> AreaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Area>("ReportingModel.AreaRegion", "Area");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Area>("ReportingModel.AreaRegion", "Area", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ReportingModel", "RegionPlant", "Plant")]
        public EntityCollection<Plant> Plants
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Plant>("ReportingModel.RegionPlant", "Plant");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Plant>("ReportingModel.RegionPlant", "Plant", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}