### C#. Net 5.0
 
#### A Simple Model- View -Controller (MVC) Design architectural pattern



`Interactions`
In addition to dividing the application into three kinds of components, the model–view–controller design defines the interactions between them.

-  A controller can send commands to the model to update the model's state (e.g., editing a document). It can also send commands to its associated view to change the view's presentation of the model (e.g., by scrolling through a document).

-  A model notifies its associated views and controllers when there has been a change in its state. This notification allows the views to produce updated output, and the controllers to change the available set of commands. 

In some cases an MVC implementation might instead be "passive," so that other components must poll the model for updates rather than being notified.


-  A view requests information from the model that it uses to generate an output representation to the user.