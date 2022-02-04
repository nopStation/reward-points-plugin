using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Misc.ExtendedRewardPointsProgram.Domain;

namespace Nop.Plugin.Misc.ExtendedRewardPointsProgram.Data
{
    [NopMigration("2020/02/03 09:30:17:6455422", "Misc.ExtendedRewardPointsProgram base schema", MigrationProcessType.Installation)]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            Create.TableFor<RewardPointsOnDateSettings>();
        }
    }
}