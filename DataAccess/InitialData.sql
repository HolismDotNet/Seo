select Id into @jsonObjectId
from NodeTypes 
where `Key` = 'JsonObject';

select Id into @jsonArrayId
from NodeTypes
where `Key` = 'JsonArray';

select Id into @textId
where `Key` = 'text';

select *
from Nodes 
where `Key` = 'FAQPage';

if not found_rows() then
    insert into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
    ('FAQPage',	null,	@jsonObjectId,	null)
end if;

select Id into @faqpageId
from Nodes
where `Key` = 'FAQPage';

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@context',	@faqpageId,	@textId,	'https://schema.org'),
('@type',	@faqpageId,	@textId,	'FAQPage'),
('mainEntity',	@faqpageId,	@jsonArrayId,	null);

select Id into @mainEntityId
from Nodes 
where `Key` = 'mainEntity'

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('Question',	(select Id from Nodes where `Key` = 'mainEntity'),	1,	null);

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@type',	(select Id from Nodes where `Key` = 'Question'),	@textId,	'Question'),
('name',	(select Id from Nodes where `Key` = 'Question'),	@textId,	null),
('acceptedAnswer',	select Id from Nodes where `Key` = 'Question'),	1,	null);

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@type',	(select Id from Nodes where `Key` = 'acceptedAnswer'),	@textId,	'Answer'),
('text',	(select Id from Nodes where `Key` = 'acceptedAnswer'),	@textId,	null);

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('Product',	null,	1,	null),
('@context',	(select Id from Nodes where `Key` = 'Product'),	@textId,	'https://schema.org/'),
('@type',	(select Id from Nodes where `Key` = 'Product'),	@textId,	'Product'),
('name',	(select Id from Nodes where `Key` = 'Product'),	@textId,	null),
('image',	(select Id from Nodes where `Key` = 'Product'),	@jsonArrayId,	null),
('description',	(select Id from Nodes where `Key` = 'Product'),	@textId,	null),
('brand',	(select Id from Nodes where `Key` = 'Product'),	1,	null),
('@type',	(select Id from Nodes where `Key` = 'Brand'),	@textId,	'Brand'),
('name',	(select Id from Nodes where `Key` = 'Brand'),	@textId,	null),
('aggregateRating',	(select Id from Nodes where `Key` = 'Product'),	1,	null),
('@type',	(select Id from Nodes where `Key` = 'aggregateRating'),	@textId,	'AggregateRating'),
('ratingValue',	(select Id from Nodes where `Key` = 'aggregateRating'),	@textId,	null),
('reviewCount',	(select Id from Nodes where `Key` = 'aggregateRating'),	@textId,	null);