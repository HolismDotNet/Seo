INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('FAQPage',	NULL,	1,	NULL);

INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('@context',	(select Id from Nodes where `Key` = 'FAQPage'),	3,	'https://schema.org'),
('@type',	(select Id from Nodes where `Key` = 'FAQPage'),	3,	'FAQPage'),
('mainEntity',	(select Id from Nodes where `Key` = 'FAQPage'),	2,	NULL);

INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('Question',	(select Id from Nodes where `Key` = 'mainEntity'),	1,	NULL);

INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('@type',	(select Id from Nodes where `Key` = 'Question'),	3,	'Question'),
('name',	(select Id from Nodes where `Key` = 'Question'),	3,	NULL),
('acceptedAnswer',	select Id from Nodes where `Key` = 'Question'),	1,	NULL);

INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('@type',	(select Id from Nodes where `Key` = 'acceptedAnswer'),	3,	'Answer'),
('text',	(select Id from Nodes where `Key` = 'acceptedAnswer'),	3,	NULL);

INSERT ignore INTO `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) VALUES
('Product',	NULL,	1,	NULL),
('@context',	(select Id from Nodes where `Key` = 'Product'),	3,	'https://schema.org/'),
('@type',	(select Id from Nodes where `Key` = 'Product'),	3,	'Product'),
('name',	(select Id from Nodes where `Key` = 'Product'),	3,	NULL),
('image',	(select Id from Nodes where `Key` = 'Product'),	2,	NULL),
('description',	(select Id from Nodes where `Key` = 'Product'),	3,	NULL),
('brand',	(select Id from Nodes where `Key` = 'Product'),	1,	NULL),
('@type',	(select Id from Nodes where `Key` = 'Brand'),	3,	'Brand'),
('name',	(select Id from Nodes where `Key` = 'Brand'),	3,	NULL),
('aggregateRating',	(select Id from Nodes where `Key` = 'Product'),	1,	NULL),
('@type',	(select Id from Nodes where `Key` = 'aggregateRating'),	3,	'AggregateRating'),
('ratingValue',	(select Id from Nodes where `Key` = 'aggregateRating'),	3,	NULL),
('reviewCount',	(select Id from Nodes where `Key` = 'aggregateRating'),	3,	NULL);