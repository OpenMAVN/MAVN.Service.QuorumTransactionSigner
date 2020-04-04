// <auto-generated />
using System;
using MAVN.Service.QuorumTransactionSigner.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.QuorumTransactionSigner.MsSqlRepositories.Migrations
{
    [DbContext(typeof(QtsContext))]
    [Migration("20190605124123_Initialisation")]
    partial class Initialisation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("quorum_transaction_signer")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.QuorumTransactionSigner.MsSqlRepositories.Entities.WalletEntity", b =>
                {
                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("address");

                    b.Property<byte[]>("PrivateKeyBackup")
                        .IsRequired()
                        .HasColumnName("private_key_backup");

                    b.Property<byte[]>("PublicKey")
                        .IsRequired()
                        .HasColumnName("public_key");

                    b.HasKey("Address");

                    b.ToTable("wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
