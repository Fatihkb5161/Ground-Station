import cv2
from ultralytics import YOLO
from sklearn.cluster import DBSCAN
from collections import Counter
import numpy as np

classNames = ["person"]

model = YOLO("yolov8n.pt")

cap = cv2.VideoCapture(1)

while True:
   success ,img = cap.read()
   results = model(img, stream= True)
   
   locations = []
   boxes = []
   for r in results:
        boxes.extend(r.boxes)
        for box in boxes:
            x1, y1, x2, y2 = box.xyxy[0]
            x1, y1, x2, y2 = int(x1), int(y1), int(x2), int(y2)
            
            if box.cls[0] == classNames.index('person'):
                cv2.rectangle(img, (x1, y1), (x2, y2), (0, 255, 0), 2)
                center = ((x1 + x2) / 2, (y1 + y2) / 2)
                locations.append([center, (x1, y1, x2, y2)])

    #gruplandırma
   if locations:
       clustering = DBSCAN(eps=50, min_samples=1).fit([loc[0] for loc in locations])
       labels = clustering.labels_

       # sayma
       counts = Counter(labels)

       # grupları çiz
       for group in set(labels):
           group_boxes = [loc[1] for loc, label in zip(locations, labels) if label == group]
           min_x = min(box[0] for box in group_boxes)
           min_y = min(box[1] for box in group_boxes)
           max_x = max(box[2] for box in group_boxes)
           max_y = max(box[3] for box in group_boxes)
           cv2.rectangle(img, (min_x, min_y), (max_x, max_y), (0, 0, 255), 2)
       
       for group, count in counts.items():
           print(f"Grup {group}: {count} kişi")
            
            
   for box in boxes:
       cls = int(box.cls[0])
       if cls < len(classNames):
           x1, y1, x2, y2 = [int(i) for i in box.xyxy[0]]
           cv2.putText(img, f'{classNames[cls]} ', (max(0, x1), max(35, y1)), cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)

   cv2.imshow("image" ,img)
   if cv2.waitKey(5) & 0xFF == ord('q'):
        break
