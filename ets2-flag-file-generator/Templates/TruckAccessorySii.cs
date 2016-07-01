namespace Ets2FlagFileGenerator.Templates
{
    internal class TruckAccessorySii : ITemplate
    {
        /*
        Message format:
        0 - Flag name (without flag_)
        1 - Truck name
        2 - l or r
        3 - left or right
        4 - Friendly flag name
        */
        public string GetTemplate(string flagName,
            string friendlyFlagName,
            string truckName,
            Direction direction) {
            var template = @"{{
accessory_addon_patch_data : {0}.{1}.flag_{2}
{{
	name: ""{4}""

	price: 10

	icon: ""flag/flag_{0}""


	exterior_model: ""/vehicle/truck/upgrade/flag/flag_{3}.pmd""

	interior_model: ""/vehicle/truck/upgrade/flag/flag_{3}.pmd""

	coll: ""/vehicle/truck/upgrade/flag/flag_{3}.pmc""

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

            return string.Format(template, flagName, truckName, (char)direction, direction.ToString().ToLower(), friendlyFlagName);
        }
    }
}
