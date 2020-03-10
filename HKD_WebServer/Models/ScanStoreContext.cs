using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HKD_WebServer.Models
{
    public partial class ScanStoreContext : DbContext
    {
        public ScanStoreContext()
        {
        }

        public ScanStoreContext(DbContextOptions<ScanStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<AdUsers> AdUsers { get; set; }
        public virtual DbSet<BossCollector> BossCollector { get; set; }
        public virtual DbSet<Cessions> Cessions { get; set; }
        public virtual DbSet<CessionScans> CessionScans { get; set; }
        public virtual DbSet<ConfigWebServer> ConfigWebServer { get; set; }
        public virtual DbSet<ContractRequess> ContractRequess { get; set; }
        public virtual DbSet<ContractRequestBitSendLog> ContractRequestBitSendLog { get; set; }
        public virtual DbSet<ContractRequestCommentType> ContractRequestCommentType { get; set; }
        public virtual DbSet<ContractRequestStatuses> ContractRequestStatuses { get; set; }
        public virtual DbSet<ContractRequestTypes> ContractRequestTypes { get; set; }
        public virtual DbSet<ContractRequestTypesStatusVisible> ContractRequestTypesStatusVisible { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<ContractScanExists> ContractScanExists { get; set; }
        public virtual DbSet<ContractScans> ContractScans { get; set; }
        public virtual DbSet<ContractSigns> ContractSigns { get; set; }
        public virtual DbSet<ContractsInRequest> ContractsInRequest { get; set; }
        public virtual DbSet<ContractsLocations> ContractsLocations { get; set; }
        public virtual DbSet<ContractsTemp> ContractsTemp { get; set; }
        public virtual DbSet<FastRequess> FastRequess { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogConverter> LogConverter { get; set; }
        public virtual DbSet<LogInsContracts> LogInsContracts { get; set; }
        public virtual DbSet<LogInsContractScans> LogInsContractScans { get; set; }
        public virtual DbSet<LogInsContractScansStatuses> LogInsContractScansStatuses { get; set; }
        public virtual DbSet<LogInsRequests> LogInsRequests { get; set; }
        public virtual DbSet<LogUpdContractAssign> LogUpdContractAssign { get; set; }
        public virtual DbSet<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
        public virtual DbSet<LogUpdRequests> LogUpdRequests { get; set; }
        public virtual DbSet<NrsIds> NrsIds { get; set; }
        public virtual DbSet<OfficeAddress> OfficeAddress { get; set; }
        public virtual DbSet<OfficeCity> OfficeCity { get; set; }
        public virtual DbSet<OutsideRequess> OutsideRequess { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnerTemplates> PartnerTemplates { get; set; }
        public virtual DbSet<RequessReson> RequessReson { get; set; }
        public virtual DbSet<RequestOutParam> RequestOutParam { get; set; }
        public virtual DbSet<ServiceTasks> ServiceTasks { get; set; }
        public virtual DbSet<ServiceTasksStatusesTask> ServiceTasksStatusesTask { get; set; }
        public virtual DbSet<ServiceTasksTypesTask> ServiceTasksTypesTask { get; set; }
        public virtual DbSet<StatusesCopy> StatusesCopy { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }

        // Unable to generate entity type for table 'dbo.tmp_excel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OldPathContractScans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Status_1c_description'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_balance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp1402'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contract_scans_Delete'. Please see the warning messages.
        // Unable to generate entity type for table 'exchange.New_status'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DelScans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contract_scans_Old'. Please see the warning messages.
        // Unable to generate entity type for table 'exchange.C$_NRS_IDS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'9_1''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.allHistScans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'9_2''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Legal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ННФ'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Остальные'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.СПИП'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'tmp_080419-1''. Please see the warning messages.
        // Unable to generate entity type for table 'podlevsky.id_hkd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp170719l'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'tmp_080419-2''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Kuznecova'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'tmp_080419-3''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'tmp_080419-4''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'tmp_080419-5''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TempIvanDel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.new_pristavs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_bit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.accs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.req_arch_comment'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.1.8.74;Database=ScanStore;user id=ScanStoreUser;password=LZ1xGhPVWmRitQmq7FuF");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Access>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lastaccess)
                    .HasColumnName("lastaccess")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdUsers>(entity =>
            {
                entity.ToTable("AD_Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(256);

                entity.Property(e => e.Pristav)
                    .IsRequired()
                    .HasColumnName("pristav")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BossCollector>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BossName)
                    .HasColumnName("bossName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pristav)
                    .HasColumnName("pristav")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cessions>(entity =>
            {
                entity.HasIndex(e => e.Date)
                    .HasName("IX_FK_dateCession");

                entity.HasIndex(e => e.PartnerId)
                    .HasName("IX_FK_PartnerCession");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignmentCess).HasColumnName("assignment_cess");

                entity.Property(e => e.CommitDate)
                    .HasColumnName("commit_date")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.NewPrefix)
                    .HasColumnName("new_prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Cessions)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerCession");
            });

            modelBuilder.Entity<CessionScans>(entity =>
            {
                entity.ToTable("Cession_scans");

                entity.HasIndex(e => e.CessionId)
                    .HasName("IX_FK_Cession_scanCession");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnName("access");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("fileName");

                entity.Property(e => e.Giantguid)
                    .HasColumnName("GIANTGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OldPath).HasColumnName("oldPath");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy)
                    .HasColumnName("status_copy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Cession)
                    .WithMany(p => p.CessionScans)
                    .HasForeignKey(d => d.CessionId)
                    .HasConstraintName("FK_Cession_scanCession");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.CessionScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .HasConstraintName("FK_Cession_scans_status_copy");
            });

            modelBuilder.Entity<ConfigWebServer>(entity =>
            {
                entity.ToTable("Config_Web_Server");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ContractRequess>(entity =>
            {
                entity.ToTable("Contract_requess");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_FK_ContractContract_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressToIl).HasColumnName("address_to_il");

                entity.Property(e => e.ArchivistComment)
                    .IsRequired()
                    .HasColumnName("archivistComment")
                    .HasMaxLength(500);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.FinishDate)
                    .HasColumnName("finishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishedUser)
                    .HasColumnName("finishedUser")
                    .HasMaxLength(100);

                entity.Property(e => e.IdBit)
                    .HasColumnName("idBit")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsUrgent).HasColumnName("isUrgent");

                entity.Property(e => e.ReqComment)
                    .HasColumnName("reqComment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestComment)
                    .IsRequired()
                    .HasColumnName("requestComment")
                    .HasMaxLength(1000);

                entity.Property(e => e.RequestDate)
                    .HasColumnName("requestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestUser)
                    .IsRequired()
                    .HasColumnName("requestUser")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestUserFio)
                    .HasColumnName("requestUserFIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SetForm).HasColumnName("setForm");

                entity.Property(e => e.SetGraph).HasColumnName("setGraph");

                entity.Property(e => e.SetPasport).HasColumnName("setPasport");

                entity.Property(e => e.UserCreate).HasColumnName("userCreate");

                entity.Property(e => e.UserFinished).HasColumnName("userFinished");

                entity.Property(e => e.WorkoutDate)
                    .HasColumnName("workoutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkoutUser)
                    .HasColumnName("workoutUser")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddressToIlNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.AddressToIl)
                    .HasConstraintName("FK_Contract_Requess_Office_Address");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Contract_requess_Contracts");

                entity.HasOne(d => d.ReqCommentNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqComment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_Comment");

                entity.HasOne(d => d.ReqStatusNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_request_status");

                entity.HasOne(d => d.ReqTypeNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_types");
            });

            modelBuilder.Entity<ContractRequestBitSendLog>(entity =>
            {
                entity.ToTable("Contract_Request_BIT_Send_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateSend)
                    .HasColumnName("date_send")
                    .HasColumnType("datetime");

                entity.Property(e => e.HtmlCode).HasColumnName("html_code");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Responce)
                    .HasColumnName("responce")
                    .IsUnicode(false);

                entity.Property(e => e.StatusSend).HasColumnName("status_send");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ContractRequestBitSendLog)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request");
            });

            modelBuilder.Entity<ContractRequestCommentType>(entity =>
            {
                entity.ToTable("Contract_request_comment_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractRequestStatuses>(entity =>
            {
                entity.ToTable("Contract_request_statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractRequestTypes>(entity =>
            {
                entity.ToTable("Contract_Request_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisibleStatus)
                    .HasColumnName("visible_status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.VisibleStatusNavigation)
                    .WithMany(p => p.ContractRequestTypes)
                    .HasForeignKey(d => d.VisibleStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_Visible_status");
            });

            modelBuilder.Entity<ContractRequestTypesStatusVisible>(entity =>
            {
                entity.ToTable("Contract_request_types_status_visible");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discript)
                    .IsRequired()
                    .HasColumnName("discript")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.HasIndex(e => e.CessionId)
                    .HasName("IX_FK_CessionContract");

                entity.HasIndex(e => e.DebtNumber)
                    .HasName("NonClusteredIndex-20170201-183430");

                entity.HasIndex(e => e.DebtorFio)
                    .HasName("IX_debitor_fio");

                entity.HasIndex(e => e.IdPkb)
                    .HasName("IX_FK_ID_PKB");

                entity.HasIndex(e => e.IdPristav)
                    .HasName("NonClusteredIndex-20170201-184004");

                entity.HasIndex(e => e.Location)
                    .HasName("IX_Location");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auditing).HasColumnName("auditing");

                entity.Property(e => e.Avtocredit).HasColumnName("avtocredit");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebtDate)
                    .HasColumnName("debt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocketAddress)
                    .HasColumnName("docket_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocketAddressUpdate)
                    .HasColumnName("docket_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtcAddress)
                    .HasColumnName("etc_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EtcAddressUpdate)
                    .HasColumnName("etc_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdNrs).HasColumnName("id_nrs");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IsAssigment)
                    .HasColumnName("isAssigment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LawyerAddress)
                    .HasColumnName("lawyer_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LawyerAddressUpdate)
                    .HasColumnName("lawyer_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAddressUpdate)
                    .HasColumnName("location_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalIlAdress)
                    .HasColumnName("original_il_adress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIlAdressUpdate)
                    .HasColumnName("original_il_adress_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtsAddress)
                    .HasColumnName("pts_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtsAddressUpdate)
                    .HasColumnName("pts_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UploadDate)
                    .HasColumnName("upload_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AuditingNavigation)
                    .WithMany(p => p.ContractsAuditingNavigation)
                    .HasForeignKey(d => d.Auditing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractsAuditing");

                entity.HasOne(d => d.AvtocreditNavigation)
                    .WithMany(p => p.ContractsAvtocreditNavigation)
                    .HasForeignKey(d => d.Avtocredit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractsAvtocredit");

                entity.HasOne(d => d.Cession)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.CessionId)
                    .HasConstraintName("FK_Contracts_Cession_id");

                entity.HasOne(d => d.IsAssigmentNavigation)
                    .WithMany(p => p.ContractsIsAssigmentNavigation)
                    .HasForeignKey(d => d.IsAssigment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_isAssigment");
            });

            modelBuilder.Entity<ContractScanExists>(entity =>
            {
                entity.ToTable("Contract_scan_exists");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractScans>(entity =>
            {
                entity.ToTable("Contract_scans");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_FK_ContractContract_scan");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.Converted).HasColumnName("converted");

                entity.Property(e => e.CsType)
                    .HasColumnName("csType")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeffectDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ExistDocument).HasDefaultValueSql("((1))");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HashFile)
                    .HasColumnName("hash_file")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertDateScan).HasColumnType("datetime");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEx).HasColumnName("isEx");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy)
                    .HasColumnName("statusCopy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_ContractContract_scan");

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Scans_Type");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_scansExistDocument");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractScansStatusesCopy");
            });

            modelBuilder.Entity<ContractSigns>(entity =>
            {
                entity.ToTable("Contract_signs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractsInRequest>(entity =>
            {
                entity.ToTable("Contracts_in_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractRequessId).HasColumnName("Contract_requess_id");

                entity.Property(e => e.OutsideRequessId).HasColumnName("Outside_requess_id");

                entity.HasOne(d => d.ContractRequess)
                    .WithMany(p => p.ContractsInRequest)
                    .HasForeignKey(d => d.ContractRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_in_request_Contract_requess");

                entity.HasOne(d => d.OutsideRequess)
                    .WithMany(p => p.ContractsInRequest)
                    .HasForeignKey(d => d.OutsideRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_in_request_Outside_requess");
            });

            modelBuilder.Entity<ContractsLocations>(entity =>
            {
                entity.ToTable("Contracts_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CsType).HasColumnName("cs_type");

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdContractScan)
                    .HasColumnName("id_contract_scan")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScanExist).HasColumnName("scan_exist");

                entity.Property(e => e.Сity)
                    .HasColumnName("сity")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.ContractsLocations)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_locations_cs_type");

                entity.HasOne(d => d.IdHkdNavigation)
                    .WithMany(p => p.ContractsLocations)
                    .HasForeignKey(d => d.IdHkd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_locations_id_hkd");
            });

            modelBuilder.Entity<ContractsTemp>(entity =>
            {
                entity.ToTable("Contracts_temp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdSess).HasColumnName("id_sess");
            });

            modelBuilder.Entity<FastRequess>(entity =>
            {
                entity.ToTable("Fast_requess");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BossEmail)
                    .HasColumnName("Boss_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectorFio)
                    .HasColumnName("Collector_FIO")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContractRequessId).HasColumnName("Contract_requess_id");

                entity.Property(e => e.DeadlineDate)
                    .HasColumnName("Deadline_date")
                    .HasColumnType("date");

                entity.Property(e => e.Descr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequessResonId).HasColumnName("Requess_reson_id");

                entity.HasOne(d => d.ContractRequess)
                    .WithMany(p => p.FastRequess)
                    .HasForeignKey(d => d.ContractRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fast_requess_Contract_requess");

                entity.HasOne(d => d.RequessReson)
                    .WithMany(p => p.FastRequess)
                    .HasForeignKey(d => d.RequessResonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fast_requess_Requess_reson");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => e.Group)
                    .HasName("IX_Group_log");

                entity.HasIndex(e => e.Time)
                    .HasName("IX_Time");

                entity.HasIndex(e => new { e.Group, e.Time, e.Text })
                    .HasName("Temp_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Error)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OperationIdentify).HasColumnName("Operation_Identify");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reestr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogConverter>(entity =>
            {
                entity.ToTable("Log_Converter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateConvert)
                    .HasColumnName("dateConvert")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("errorMessage")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtension)
                    .HasColumnName("fileExtension")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasColumnName("host")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdContractScan).HasColumnName("idContractScan");

                entity.Property(e => e.NewPath)
                    .HasColumnName("newPath")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OldPath)
                    .HasColumnName("oldPath")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnName("result");
            });

            modelBuilder.Entity<LogInsContracts>(entity =>
            {
                entity.ToTable("Log_Ins_Contracts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auditing).HasColumnName("auditing");

                entity.Property(e => e.Avtocredit).HasColumnName("avtocredit");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DebtDate)
                    .HasColumnName("debt_date")
                    .HasColumnType("date");

                entity.Property(e => e.DebtFio)
                    .IsRequired()
                    .HasColumnName("debt_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ErrMess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.PkbId).HasColumnName("pkb_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsContracts)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contracts_idTask");
            });

            modelBuilder.Entity<LogInsContractScans>(entity =>
            {
                entity.ToTable("Log_Ins_Contract_scans");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmBox)
                    .IsRequired()
                    .HasColumnName("amBox")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AmFolder)
                    .IsRequired()
                    .HasColumnName("amFolder")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ErrorCode).HasColumnName("errorCode");

                entity.Property(e => e.ErrorMess)
                    .HasColumnName("errorMess")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExistDocument).HasDefaultValueSql("((1))");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdCsOnAddScan).HasColumnName("idCsOnAddScan");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LenInFile).HasColumnName("lenInFile");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathIn)
                    .HasColumnName("pathIn")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PathOut)
                    .HasColumnName("pathOut")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScType).HasColumnName("scType");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contract_scansExistDocument");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Task_Id");

                entity.HasOne(d => d.ScTypeNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.ScType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Scans_Types");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contract_scans_statuses_id");
            });

            modelBuilder.Entity<LogInsContractScansStatuses>(entity =>
            {
                entity.ToTable("Log_Ins_Contract_scans_statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogInsRequests>(entity =>
            {
                entity.ToTable("Log_Ins_Requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("idHkd");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestUser)
                    .HasColumnName("requestUser")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsRequests)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Task");

                entity.HasOne(d => d.ReqTypeNavigation)
                    .WithMany(p => p.LogInsRequests)
                    .HasForeignKey(d => d.ReqType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_requestType");
            });

            modelBuilder.Entity<LogUpdContractAssign>(entity =>
            {
                entity.ToTable("Log_Upd_Contract_Assign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorCode).HasColumnName("errorCode");

                entity.Property(e => e.ErrorMess)
                    .HasColumnName("errorMess")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("idHkd");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.IsAssign).HasColumnName("isAssign");

                entity.Property(e => e.StatusUpdate).HasColumnName("statusUpdate");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdContractAssign)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTask_TypeTask");
            });

            modelBuilder.Entity<LogUpdContractScansLocations>(entity =>
            {
                entity.ToTable("Log_Upd_Contract_Scans_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsType).HasColumnName("cs_type");

                entity.Property(e => e.ErrMess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusUpd).HasColumnName("statusUpd");

                entity.Property(e => e.Сity)
                    .HasColumnName("сity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_csTypes");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locationsExistDocument");

                entity.HasOne(d => d.IdHkdNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.IdHkd)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_idHkd");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_idTask");
            });

            modelBuilder.Entity<LogUpdRequests>(entity =>
            {
                entity.ToTable("Log_Upd_Requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdReq).HasColumnName("idReq");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.ReqStatus).HasColumnName("reqStatus");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdRequests)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_UpdRequests_idTask");
            });

            modelBuilder.Entity<NrsIds>(entity =>
            {
                entity.HasKey(e => e.IdNrs);

                entity.ToTable("NRS_IDS", "exchange");

                entity.Property(e => e.IdNrs)
                    .HasColumnName("id_nrs")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contract)
                    .HasColumnName("contract")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreditDate)
                    .HasColumnName("credit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdPkb)
                    .HasColumnName("id_pkb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfficeAddress>(entity =>
            {
                entity.ToTable("Office_Address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasColumnName("city");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.OfficeAddress)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Office_City");
            });

            modelBuilder.Entity<OfficeCity>(entity =>
            {
                entity.ToTable("Office_City");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutsideRequess>(entity =>
            {
                entity.ToTable("Outside_requess");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MsgBody)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubjectMsg)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("Template_id");

                entity.Property(e => e.UserSend)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OutsideRequess)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Outside_requess_Template");
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.PrimaryCreditor).HasColumnName("primary_creditor");
            });

            modelBuilder.Entity<PartnerTemplates>(entity =>
            {
                entity.ToTable("Partner_templates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.TemplateId).HasColumnName("Template_id");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerTemplates)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Partner_templates_Partners");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.PartnerTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Partner_templates_Templates");
            });

            modelBuilder.Entity<RequessReson>(entity =>
            {
                entity.ToTable("Requess_reson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestOutParam>(entity =>
            {
                entity.ToTable("Request_out_param");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.RequestOutParam)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_reqeust_out_param_ToTemplateId");
            });

            modelBuilder.Entity<ServiceTasks>(entity =>
            {
                entity.ToTable("Service_Tasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParamTask)
                    .HasColumnName("paramTask")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PathInFile)
                    .HasColumnName("pathInFile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PathOutFile)
                    .HasColumnName("pathOutFile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponceMessage)
                    .HasColumnName("responceMessage")
                    .IsUnicode(false);

                entity.Property(e => e.TypeInFile).HasColumnName("typeInFile");

                entity.Property(e => e.TypeOutFile).HasColumnName("typeOutFile");

                entity.Property(e => e.TypeStatus).HasColumnName("typeStatus");

                entity.Property(e => e.TypeTask).HasColumnName("typeTask");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasColumnName("userCreate")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserFileName)
                    .HasColumnName("userFileName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.TypeStatusNavigation)
                    .WithMany(p => p.ServiceTasks)
                    .HasForeignKey(d => d.TypeStatus)
                    .HasConstraintName("FK_Service_StatusesTask");

                entity.HasOne(d => d.TypeTaskNavigation)
                    .WithMany(p => p.ServiceTasks)
                    .HasForeignKey(d => d.TypeTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_TypesTask");
            });

            modelBuilder.Entity<ServiceTasksStatusesTask>(entity =>
            {
                entity.ToTable("Service_Tasks_StatusesTask");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceTasksTypesTask>(entity =>
            {
                entity.ToTable("Service_Tasks_TypesTask");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusesCopy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dossier)
                    .HasColumnName("dossier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIl)
                    .HasColumnName("original_il")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasColumnName("post")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pts)
                    .HasColumnName("pts")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
