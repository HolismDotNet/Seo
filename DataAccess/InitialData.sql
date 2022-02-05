select Id into @jsonObjectId
from NodeTypes 
where `Key` = 'JsonObject';

select Id into @jsonArrayId
from NodeTypes
where `Key` = 'JsonArray';

select Id into @textId
from NodeTypes
where `Key` = 'text';

insert into Nodes (`Key`, ParentId, NodeTypeId)
select 'FAQPage', null, 1
where not exists
(
    select null
    from Nodes 
    where `Key` <=> 'FAQPage'
    and ParentId <=> null
);

select Id into @faqpageId
from Nodes
where `Key` = 'FAQPage';

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@context', @faqpageId, @textId, 'https://schema.org'),
('@type', @faqpageId, @textId, 'FAQPage'),
('mainEntity', @faqpageId, @jsonArrayId, null);

select Id into @mainEntityId
from Nodes 
where `Key` = 'mainEntity';

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('Question', @mainEntityId, 1, null);

select Id into @questionId
from Nodes
where `Key` = 'Question';

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@type', @questionId, @textId, 'Question'),
('name', @questionId, @textId, null),
('acceptedAnswer', @questionId, 1, null);

select Id into @acceptedAnswerId
from Nodes
where `Key` = 'acceptedAnswer';

insert ignore into `Nodes` (`Key`, `ParentId`, `NodeTypeId`, `Value`) values
('@type', @acceptedAnswerId, @textId, 'Answer'),
('text', @acceptedAnswerId, @textId, null);

insert into Nodes (`Key`, ParentId, NodeTypeId)
select 'Product', null, 1
where not exists
(
    select null
    from Nodes 
    where `Key` <=> 'Product'
    and ParentId <=> null
);

select Id into @productId
from Nodes 
where `Key` = 'Product';

insert ignore into Nodes (`Key`, ParentId, NodeTypeId, `Value`) values
('@context', @productId, @textId, 'https://schema.org/'),
('@type', @productId, @textId, 'Product'),
('name', @productId, @textId, null),
('image', @productId, @jsonArrayId, null),
('description', @productId, @textId, null),
('brand', @productId, 1, null);

select Id into @brandId
from Nodes
where `Key` = 'brand';

insert ignore into Nodes (`Key`, ParentId, NodeTypeId, `Value`) values
('@type', @brandId, @textId, 'Brand'),
('name', @brandId, @textId, null),
('aggregateRating', @productId, 1, null);

select Id into @aggregateRagingId
from Nodes
where `Key` = 'aggregateRating';

insert ignore into Nodes (`Key`, ParentId, NodeTypeId, `Value`) values
('@type', @aggregateRagingId, @textId, 'AggregateRating'),
('ratingValue', @aggregateRagingId, @textId, null),
('reviewCount', @aggregateRagingId, @textId, null);