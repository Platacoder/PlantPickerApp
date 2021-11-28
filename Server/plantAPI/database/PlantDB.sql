USE master
GO

If DB_ID('PlantDB') IS NOT NULL
BEGIN
	ALTER DATABASE PlantDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE PlantDB;
END

CREATE DATABASE PlantDB;
GO

USE PlantDB;
GO

BEGIN TRANSACTION

CREATE TABLE plant_profiles (
	plant_id INT IDENTITY(1,1) NOT NULL,
	plant_type CHAR(15) NOT NULL,
	common_name CHAR(50) NOT NULL,
	scientific_name CHAR(50) NOT NULL,
	light_requirements VARCHAR(50) NOT NULL,
	soil_type VARCHAR(50) NOT NULL,
	soil_moisture VARCHAR(50) NOT NULL,
	summary VARCHAR(350),
	CONSTRAINT [PK_plant_profiles] PRIMARY KEY (plant_id)

);
COMMIT TRANSACTION

--Insertion of data

--Data grabbed and manually inputted from https://www.jerseyyards.org/plant/

INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Grass', 'Little Bluestem', 'Schizachyrium scoparium', 'Full Sun', 'Loam, Organic, Sandy, Clay', 'Dry', '"Little Bluestem is an ornamental grass with small, delicate, purplish-blue-bronze flowers, which appear in August. Leaf blades are blue at the base, turning green at the tip. Dried seed heads are silvery-white and offer winter interest.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Grass', 'Woolgrass', 'Scirpus cyperinus', 'Full Sun', 'Loam, Organic, Sandy, Clay', 'Moist, Wet', 'Woolgrass needs wet, partly shady conditions. This wildlife-friendly plant has seeds and roots that are eaten by waterfowl. It also provides waterfowl with cover and nesting sites. It is a host plant for butterfly and moth larvae.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Herbacious', 'Butterfly Weed', 'Asclepias tuberosa', 'Full Sun', 'Loam, Organic, Sandy', 'Dry', 'Butterfly Weed is a long-blooming, drought-tolerant, wildlife-friendly perennial. Its showy, bright orange flowers bloom in flat-topped clusters, June-August. The nectar is attractive to bees, butterflies, and hummingbirds; it has special value for native bees.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Herbacious', 'Easter Bluestar', 'Amsonia tabernaemontana', 'Full Sun, Partial Shade', 'Loam, Organic, Sandy', 'Dry, Moist', 'Eastern Bluestar is an easy-to-grow, clump-forming perennial. Clusters of light blue, star-shaped flowers bloom at the top of stems in late spring to early summer.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Shrub', 'Canadian Serviceberry', 'Amelanchier canadensis', 'Full Sun, Partial Shade', 'Loam, Organic, Sandy', 'Dry, Moist', 'Canadian Serviceberry is a wildlife-friendly, large deciduous shrub. Drooping clusters of slightly fragrant, white flowers bloom before leaves appear, March-April.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Shrub', 'Summersweet', 'Clethra alnifolia', 'Full Sun, Partial Shade, Shade', 'Loam, Organic, Sandy', 'Dry, Moist', 'Summersweet is a multi-branched deciduous shrub with dark green, aromatic leaves. It is one of the few summer-flowering shrubs that will bloom in shade. The sweetly fragrant, white flowers bloom in upright clusters on the tips of stems, July-August.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Tree', 'Boxelder', 'Acer negundo', 'Full Sun', 'Loam, Organic, Sandy, Clay', 'Dry, Moist, Wet', 'Boxelder is a medium-sized, fast-growing deciduous tree. Its compound leaves are different from most other maples. Non-showy, yellow-green flowers bloom March-April on separate male and female trees.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Tree', 'Pawpaw', 'Asimina triloba', 'Full Sun, Partial Shade', 'Loam, Organic, Sandy', 'Dry, Moist, Wet', 'Pawpaw is a small understory tree or large shrub, which grows to form thickets. It has large, drooping, tropical-like leaves. Its cup-shaped, purple flowers bloom April-May, followed by large, green, edible fruits that taste like a mixture of bananas and pineapples.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Tree', 'Pawpaw', 'Asimina triloba', 'Full Sun, Partial Shade', 'Loam, Organic, Sandy', 'Dry, Moist, Wet', 'Pawpaw is a small understory tree or large shrub, which grows to form thickets. It has large, drooping, tropical-like leaves. Its cup-shaped, purple flowers bloom April-May, followed by large, green, edible fruits that taste like a mixture of bananas and pineapples.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Vine', 'Trumpet Honeysuckle', 'Lonicera sempervirens', 'Full Sun, Partial Shade', 'Loam, Organic, Sandy, Clay', 'Dry', 'Trumpet Honeysuckle is a twining, wildlife-friendly deciduous vine, which will attract hummingbirds, butterflies, and bees to your garden! It has red-pink-orange, trumpet-shaped flowers that bloom between May-June.')
INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) VALUES ('Vine', 'Virginia Creeper', 'Parthenocissus quinquefolia', 'Full Sun, Partial Shade, Shade', 'Loam, Organic, Sandy, Clay', 'Dry', '"Virginia Creeper is a wildlife-friendly, woody, deciduous vine. Insignificant, greenish-white flowers bloom May-August, leading to attractive, dark blue to black berries, valued as food by birds and wildlife. Green, compound-palmate leaves turn deep red-crimson in the fall.')


