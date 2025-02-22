using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DofusUnlocked.API.Migrations
{
    /// <inheritdoc />
    public partial class FirstSpellsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImgUrl = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImgUrl = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EffectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImgUrl = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false),
                    VariantSpellId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_CharacterClasses_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_Spells_VariantSpellId",
                        column: x => x.VariantSpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConditionValue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpellRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpellId = table.Column<int>(type: "int", nullable: false),
                    RequiredLevel = table.Column<int>(type: "int", nullable: false),
                    MinRange = table.Column<int>(type: "int", nullable: false),
                    MaxRange = table.Column<int>(type: "int", nullable: false),
                    IsRangeModifiable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsLineOfSightRequired = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CastInDiagonal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CastInLine = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    APCost = table.Column<int>(type: "int", nullable: false),
                    MaxStack = table.Column<int>(type: "int", nullable: true),
                    Cooldown = table.Column<int>(type: "int", nullable: false),
                    GlobalCooldown = table.Column<int>(type: "int", nullable: false),
                    CanCastOnEmptyCell = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellRanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellRanks_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpellEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpellRankId = table.Column<int>(type: "int", nullable: false),
                    EffectTypeId = table.Column<int>(type: "int", nullable: false),
                    DamageTypeId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    EffectOrder = table.Column<int>(type: "int", nullable: false),
                    MinValue = table.Column<int>(type: "int", nullable: true),
                    MaxValue = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellEffects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellEffects_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpellEffects_EffectTypes_EffectTypeId",
                        column: x => x.EffectTypeId,
                        principalTable: "EffectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellEffects_SpellRanks_SpellRankId",
                        column: x => x.SpellRankId,
                        principalTable: "SpellRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellEffects_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_StateId",
                table: "Conditions",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellEffects_DamageTypeId",
                table: "SpellEffects",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellEffects_EffectTypeId",
                table: "SpellEffects",
                column: "EffectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellEffects_SpellRankId",
                table: "SpellEffects",
                column: "SpellRankId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellEffects_StateId",
                table: "SpellEffects",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellRanks_SpellId",
                table: "SpellRanks",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_CharacterClassId",
                table: "Spells",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_VariantSpellId",
                table: "Spells",
                column: "VariantSpellId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "SpellEffects");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "EffectTypes");

            migrationBuilder.DropTable(
                name: "SpellRanks");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "CharacterClasses");
        }
    }
}
