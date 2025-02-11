# RemovableTagModel Class
 _**\[This is preliminary documentation and is subject to change.\]**_

View model backing a <a href="ef583703-d11c-ba42-c90f-7c19350d1e2b">RemovableTag</a> user control.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="11d6cbca-a6ed-ac3c-8cdb-a81177e6f4fd">WetHatLab.OneNote.TaggingKit.common.ObservableObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="c74fe645-91b2-831c-6869-763addf746aa">WetHatLab.OneNote.TaggingKit.common.ui.TagModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">WetHatLab.OneNote.TaggingKit.common.ui.FilterableTagModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WetHatLab.OneNote.TaggingKit.manage.RemovableTagModel<br />
**Namespace:**&nbsp;<a href="6c09c3a7-2ecd-33d5-2ed0-acefd996500f">WetHatLab.OneNote.TaggingKit.manage</a><br />**Assembly:**&nbsp;OneNoteTaggingKit (in OneNoteTaggingKit.dll) Version: 4.0.8059.31599

## Syntax

**C#**<br />
``` C#
public class RemovableTagModel : FilterableTagModel
```

The RemovableTagModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="5235a1df-2564-7acd-7bf3-912397a924a9">RemovableTagModel</a></td><td>
Create a new instance of the view model.</td></tr></table>&nbsp;
<a href="#removabletagmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="247b1b70-3cb1-b8ba-9e93-a518e8400840">HasHighlights</a></td><td>
Determine if the tag's name has any highlights.
 (Inherited from <a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">FilterableTagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="c188c327-b193-b58d-7934-38711725d451">HighlightedTagName</a></td><td>
Get/set the list of tagname highlights.
 (Inherited from <a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">FilterableTagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="deeba836-ff7c-07be-4d16-7a113ba7eb30">Highlighter</a></td><td>
Set/get the highlighter object which is used to mark portions of the tag name which match one or more strings.
 (Inherited from <a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">FilterableTagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="eb68a667-f7fa-713b-16e9-e3f50d68b647">IndicatorForeground</a></td><td>
Get the color of the tag use count indicator.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="a3c85c71-c40d-240a-c2cd-16186991c64f">IsFullMatch</a></td><td>
Determine if the highlghting pattern fully matches the tag name.
 (Inherited from <a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">FilterableTagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="39f847f2-e662-d38f-d07c-23ce3a2b1ee9">Key</a></td><td>
Get the unique key of this tag.
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="ecdd57d2-f93d-815e-3b09-01670bed67c3">LocalName</a></td><td>
Get/set the editable tag name.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="a43b259f-6bf7-d03e-274e-7d6775a5577a">SortKey</a></td><td>
Get a key for this tag which is suitable for sorting the tag models-
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="f13dd952-ee76-bf63-e6ca-abc238060d35">Tag</a></td><td>
Get or set the page tag which keeps track of the pages having this tag.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="135e6965-9f92-1c23-f19e-7e1943e7e0c0">TagIndicator</a></td><td>
Get/set the tag indicator (postfix string).
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="2b686f19-a0de-d569-81d1-4eb38e69e00b">TagIndicatorColor</a></td><td>
Get/set the forground color of the tag indicator
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="1fb2d87e-bc21-a776-f082-c3038bb76179">TagName</a></td><td>
Get or set the name of a page tag represented by this model.
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="e964eec6-7268-6b84-ebb8-5f7edf4a58af">TagType</a></td><td>
Get the foreground color for the tag indicator.
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="1fd994d7-e049-994c-1ebb-c3a2c6323c85">TagVisibility</a></td><td>
The visibility of the tag.
 (Inherited from <a href="c74fe645-91b2-831c-6869-763addf746aa">TagModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="795e5c87-fcf0-59bc-725c-d489a3892dff">UseCount</a></td><td>
Get the number of pages having this tag.</td></tr></table>&nbsp;
<a href="#removabletagmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="35d00535-1e7e-22a1-cb53-7637d411dec7">Dispose</a></td><td>
Clear all property handlers for this object.
 (Inherited from <a href="11d6cbca-a6ed-ac3c-8cdb-a81177e6f4fd">ObservableObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td>
Serves as the default hash function.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td>
Gets the Type of the current instance.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td>
Creates a shallow copy of the current Object.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")![Code example](media/CodeExample.png "Code example")</td><td><a href="5d0bdc82-8ecd-785e-4513-483e68b3fbe6">RaisePropertyChanged</a></td><td>
Raise a change event for
 (Inherited from <a href="11d6cbca-a6ed-ac3c-8cdb-a81177e6f4fd">ObservableObject</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="7c715be7-7d65-93f6-9d8b-5a28272184a8">TagModelPropertyChanged</a></td><td>
Track changes in the tag view model.
 (Overrides <a href="57ee75cc-7fbb-3f1f-d50b-bfafc4604d62">FilterableTagModel.TagModelPropertyChanged(Object, PropertyChangedEventArgs)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td>
Returns a string that represents the current object.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="0bd16b12-5ebc-92e7-e707-6e9d79ff2864">UpdateTagVisibility</a></td><td>
Compute the visibility based on changes to the <a href="c188c327-b193-b58d-7934-38711725d451">HighlightedTagName</a> property.
 (Inherited from <a href="ff6915ee-46c5-1c9e-7b33-f1a306ce968d">FilterableTagModel</a>.)</td></tr></table>&nbsp;
<a href="#removabletagmodel-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="185ee554-4bcc-0dd9-592a-42256ef46b35">PropertyChanged</a></td><td>
Event to notify registered handlers about property changes
 (Inherited from <a href="11d6cbca-a6ed-ac3c-8cdb-a81177e6f4fd">ObservableObject</a>.)</td></tr></table>&nbsp;
<a href="#removabletagmodel-class">Back to Top</a>

## Remarks
Provides properties to allow adding/removing/renaming tags

## See Also


#### Reference
<a href="6c09c3a7-2ecd-33d5-2ed0-acefd996500f">WetHatLab.OneNote.TaggingKit.manage Namespace</a><br />