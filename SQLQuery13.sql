﻿SELECT * FROM Part
WHERE PartID NOT IN (SELECT DISTINCT PartID FROM OrderDetail);