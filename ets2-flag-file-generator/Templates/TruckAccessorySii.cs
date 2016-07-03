namespace Ets2FlagFileGenerator.Templates
{
    internal class TruckAccessorySii : ITemplate
    {
        /*
        Message format:
        0 - Flag Id
        1 - Truck Id
        2 - Direction
        3 - Display Name
        4 - UI TextureName
        5 - Direction Display Name
        */
        public string GetTemplate(string flagId,
            string displayName,
            string truckName,
            Direction direction,
            string uiTextureName) {
            var template = @"SiiNunit
{{
accessory_addon_patch_data : {0}.{1}.flag_{2}
{{
	name: ""{3}""
	price: 10
	icon: ""flag/{4}""

	exterior_model: ""/vehicle/truck/upgrade/flag/flag_{5}.pmd""
	interior_model: ""/vehicle/truck/upgrade/flag/flag_{5}.pmd""
	coll: ""/vehicle/truck/upgrade/flag/flag_{5}.pmc""
	data: .patch.phys_data
}}
physics_patch_data : .patch.phys_data
{{
	material: ""/vehicle/truck/upgrade/flag/{0}.mat""
	area_density: 0.1
	linear_stiffness: 0.9
	drag_coefficient: 3.0
	lift_coefficient: 5.0
	aero_model_type: ""AT_two_side_lift_drag""
	x_res: 10
	y_res: 8
	x_size: 0.4
	y_size: 0.28
 
}}
}}";

            return string.Format(template, flagId, truckName, (char)direction, displayName, uiTextureName, direction.ToString().ToLower());
        }
    }
}
