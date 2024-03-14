using System;
using System.Collections.Generic;
using GymManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DbContexts;

public partial class GymManagerDbContext : DbContext
{
    public GymManagerDbContext()
    {
    }

    public GymManagerDbContext(DbContextOptions<GymManagerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Banking> Bankings { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberBanking> MemberBankings { get; set; }

    public virtual DbSet<MemberMembership> MemberMemberships { get; set; }

    public virtual DbSet<MemberPayment> MemberPayments { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost:5433;Database=GymManagerDB;Username=postgres;Password=password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banking>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("banking_pkey");

            entity.ToTable("banking");

            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.InsitutionNumber).HasColumnName("insitution_number");
            entity.Property(e => e.TransitNumber).HasColumnName("transit_number");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("card");

            entity.HasIndex(e => e.CardId, "card_card_id_key").IsUnique();

            entity.Property(e => e.CardId).HasColumnName("card_id");
            entity.Property(e => e.MemberId).HasColumnName("member_id");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("card_member_id_fkey");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("member_id");

            entity.ToTable("member");

            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.Address)
                .HasColumnType("character varying")
                .HasColumnName("address");
            entity.Property(e => e.CancelDate).HasColumnName("cancel_date");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying(6)[]")
                .HasColumnName("postal_code");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<MemberBanking>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("member_banking_pkey");

            entity.ToTable("member_banking");

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("member_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");

            entity.HasOne(d => d.Account).WithMany(p => p.MemberBankings)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("member_banking_account_id_fkey");

            entity.HasOne(d => d.Member).WithOne(p => p.MemberBanking)
                .HasForeignKey<MemberBanking>(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("member_banking_member_id_fkey");
        });

        modelBuilder.Entity<MemberMembership>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("member_membership_pkey");

            entity.ToTable("member_membership");

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("member_id");
            entity.Property(e => e.MembershipId).HasColumnName("membership_id");

            entity.HasOne(d => d.Member).WithOne(p => p.MemberMembership)
                .HasForeignKey<MemberMembership>(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("member_membership_member_id_fkey");

            entity.HasOne(d => d.Membership).WithMany(p => p.MemberMemberships)
                .HasForeignKey(d => d.MembershipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("member_membership_membership_id_fkey");
        });

        modelBuilder.Entity<MemberPayment>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("member_payments_pkey");

            entity.ToTable("member_payments");

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("member_id");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");

            entity.HasOne(d => d.Member).WithOne(p => p.MemberPayment)
                .HasForeignKey<MemberPayment>(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("member_payments_member_id_fkey");

            entity.HasOne(d => d.Payment).WithMany(p => p.MemberPayments)
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("member_payments_payment_id_fkey");
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("membership_pkey");

            entity.ToTable("membership");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payments_pkey");

            entity.ToTable("payments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
