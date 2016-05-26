var NAVTREE =
[
  [ "Interactive Multimedia : March 2014", "index.html", [
    [ "Class List", "annotated.html", [
      [ "BarrelBehaviour", "class_barrel_behaviour.html", null ],
      [ "BarrelBehaviour2", "class_barrel_behaviour2.html", null ],
      [ "CountdownTimer", "class_countdown_timer.html", null ],
      [ "CubeBehaviourScript", "class_cube_behaviour_script.html", null ],
      [ "DestroyWhenHit", "class_destroy_when_hit.html", null ],
      [ "DoorAnimationController", "class_door_animation_controller.html", null ],
      [ "DoorSensor", "class_door_sensor.html", null ],
      [ "DoorSensor2", "class_door_sensor2.html", null ],
      [ "FactoryPipeBehaviour", "class_factory_pipe_behaviour.html", null ],
      [ "FireProjectile", "class_fire_projectile.html", null ],
      [ "FontScript", "class_font_script.html", null ],
      [ "GameGUI", "class_game_g_u_i.html", null ],
      [ "GameManager", "class_game_manager.html", null ],
      [ "MushroomCircleBehaviour", "class_mushroom_circle_behaviour.html", null ],
      [ "PlayerBehaviour", "class_player_behaviour.html", null ],
      [ "RolloverButton", "class_rollover_button.html", null ],
      [ "SpiderBulletBehaviour", "class_spider_bullet_behaviour.html", null ],
      [ "SpiderGunBehaviour", "class_spider_gun_behaviour.html", null ],
      [ "SpiderLifeBehaviour", "class_spider_life_behaviour.html", null ],
      [ "SpiderrangeBehaviour", "class_spiderrange_behaviour.html", null ],
      [ "ToxicAreaBehaviour", "class_toxic_area_behaviour.html", null ],
      [ "WandCubeBehaviour", "class_wand_cube_behaviour.html", null ]
    ] ],
    [ "Class Index", "classes.html", null ],
    [ "Class Members", "functions.html", null ],
    [ "File List", "files.html", [
      [ "C:/z_doxygen/src/BarrelBehaviour.cs", "_barrel_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/BarrelBehaviour2.cs", "_barrel_behaviour2_8cs.html", null ],
      [ "C:/z_doxygen/src/CountdownTimer.cs", "_countdown_timer_8cs.html", null ],
      [ "C:/z_doxygen/src/CubeBehaviourScript.cs", "_cube_behaviour_script_8cs.html", null ],
      [ "C:/z_doxygen/src/DestroyWhenHit.cs", "_destroy_when_hit_8cs.html", null ],
      [ "C:/z_doxygen/src/DoorAnimationController.cs", "_door_animation_controller_8cs.html", null ],
      [ "C:/z_doxygen/src/DoorSensor.cs", "_door_sensor_8cs.html", null ],
      [ "C:/z_doxygen/src/DoorSensor2.cs", "_door_sensor2_8cs.html", null ],
      [ "C:/z_doxygen/src/FactoryPipeBehaviour.cs", "_factory_pipe_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/FireProjectile.cs", "_fire_projectile_8cs.html", null ],
      [ "C:/z_doxygen/src/FontScript.cs", "_font_script_8cs.html", null ],
      [ "C:/z_doxygen/src/GameGUI.cs", "_game_g_u_i_8cs.html", null ],
      [ "C:/z_doxygen/src/GameManager.cs", "_game_manager_8cs.html", null ],
      [ "C:/z_doxygen/src/MushroomCircleBehaviour.cs", "_mushroom_circle_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/PlayerBehaviour.cs", "_player_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/RolloverButton.cs", "_rollover_button_8cs.html", null ],
      [ "C:/z_doxygen/src/SpiderBulletBehaviour.cs", "_spider_bullet_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/SpiderGunBehaviour.cs", "_spider_gun_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/SpiderLifeBehaviour.cs", "_spider_life_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/SpiderrangeBehaviour.cs", "_spiderrange_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/ToxicAreaBehaviour.cs", "_toxic_area_behaviour_8cs.html", null ],
      [ "C:/z_doxygen/src/WandCubeBehaviour.cs", "_wand_cube_behaviour_8cs.html", null ]
    ] ]
  ] ]
];

function createIndent(o,domNode,node,level)
{
  if (node.parentNode && node.parentNode.parentNode)
  {
    createIndent(o,domNode,node.parentNode,level+1);
  }
  var imgNode = document.createElement("img");
  if (level==0 && node.childrenData)
  {
    node.plus_img = imgNode;
    node.expandToggle = document.createElement("a");
    node.expandToggle.href = "javascript:void(0)";
    node.expandToggle.onclick = function() 
    {
      if (node.expanded) 
      {
        $(node.getChildrenUL()).slideUp("fast");
        if (node.isLast)
        {
          node.plus_img.src = node.relpath+"ftv2plastnode.png";
        }
        else
        {
          node.plus_img.src = node.relpath+"ftv2pnode.png";
        }
        node.expanded = false;
      } 
      else 
      {
        expandNode(o, node, false);
      }
    }
    node.expandToggle.appendChild(imgNode);
    domNode.appendChild(node.expandToggle);
  }
  else
  {
    domNode.appendChild(imgNode);
  }
  if (level==0)
  {
    if (node.isLast)
    {
      if (node.childrenData)
      {
        imgNode.src = node.relpath+"ftv2plastnode.png";
      }
      else
      {
        imgNode.src = node.relpath+"ftv2lastnode.png";
        domNode.appendChild(imgNode);
      }
    }
    else
    {
      if (node.childrenData)
      {
        imgNode.src = node.relpath+"ftv2pnode.png";
      }
      else
      {
        imgNode.src = node.relpath+"ftv2node.png";
        domNode.appendChild(imgNode);
      }
    }
  }
  else
  {
    if (node.isLast)
    {
      imgNode.src = node.relpath+"ftv2blank.png";
    }
    else
    {
      imgNode.src = node.relpath+"ftv2vertline.png";
    }
  }
  imgNode.border = "0";
}

function newNode(o, po, text, link, childrenData, lastNode)
{
  var node = new Object();
  node.children = Array();
  node.childrenData = childrenData;
  node.depth = po.depth + 1;
  node.relpath = po.relpath;
  node.isLast = lastNode;

  node.li = document.createElement("li");
  po.getChildrenUL().appendChild(node.li);
  node.parentNode = po;

  node.itemDiv = document.createElement("div");
  node.itemDiv.className = "item";

  node.labelSpan = document.createElement("span");
  node.labelSpan.className = "label";

  createIndent(o,node.itemDiv,node,0);
  node.itemDiv.appendChild(node.labelSpan);
  node.li.appendChild(node.itemDiv);

  var a = document.createElement("a");
  node.labelSpan.appendChild(a);
  node.label = document.createTextNode(text);
  a.appendChild(node.label);
  if (link) 
  {
    a.href = node.relpath+link;
  } 
  else 
  {
    if (childrenData != null) 
    {
      a.className = "nolink";
      a.href = "javascript:void(0)";
      a.onclick = node.expandToggle.onclick;
      node.expanded = false;
    }
  }

  node.childrenUL = null;
  node.getChildrenUL = function() 
  {
    if (!node.childrenUL) 
    {
      node.childrenUL = document.createElement("ul");
      node.childrenUL.className = "children_ul";
      node.childrenUL.style.display = "none";
      node.li.appendChild(node.childrenUL);
    }
    return node.childrenUL;
  };

  return node;
}

function showRoot()
{
  var headerHeight = $("#top").height();
  var footerHeight = $("#nav-path").height();
  var windowHeight = $(window).height() - headerHeight - footerHeight;
  navtree.scrollTo('#selected',0,{offset:-windowHeight/2});
}

function expandNode(o, node, imm)
{
  if (node.childrenData && !node.expanded) 
  {
    if (!node.childrenVisited) 
    {
      getNode(o, node);
    }
    if (imm)
    {
      $(node.getChildrenUL()).show();
    } 
    else 
    {
      $(node.getChildrenUL()).slideDown("fast",showRoot);
    }
    if (node.isLast)
    {
      node.plus_img.src = node.relpath+"ftv2mlastnode.png";
    }
    else
    {
      node.plus_img.src = node.relpath+"ftv2mnode.png";
    }
    node.expanded = true;
  }
}

function getNode(o, po)
{
  po.childrenVisited = true;
  var l = po.childrenData.length-1;
  for (var i in po.childrenData) 
  {
    var nodeData = po.childrenData[i];
    po.children[i] = newNode(o, po, nodeData[0], nodeData[1], nodeData[2],
        i==l);
  }
}

function findNavTreePage(url, data)
{
  var nodes = data;
  var result = null;
  for (var i in nodes) 
  {
    var d = nodes[i];
    if (d[1] == url) 
    {
      return new Array(i);
    }
    else if (d[2] != null) // array of children
    {
      result = findNavTreePage(url, d[2]);
      if (result != null) 
      {
        return (new Array(i).concat(result));
      }
    }
  }
  return null;
}

function initNavTree(toroot,relpath)
{
  var o = new Object();
  o.toroot = toroot;
  o.node = new Object();
  o.node.li = document.getElementById("nav-tree-contents");
  o.node.childrenData = NAVTREE;
  o.node.children = new Array();
  o.node.childrenUL = document.createElement("ul");
  o.node.getChildrenUL = function() { return o.node.childrenUL; };
  o.node.li.appendChild(o.node.childrenUL);
  o.node.depth = 0;
  o.node.relpath = relpath;

  getNode(o, o.node);

  o.breadcrumbs = findNavTreePage(toroot, NAVTREE);
  if (o.breadcrumbs == null)
  {
    o.breadcrumbs = findNavTreePage("index.html",NAVTREE);
  }
  if (o.breadcrumbs != null && o.breadcrumbs.length>0)
  {
    var p = o.node;
    for (var i in o.breadcrumbs) 
    {
      var j = o.breadcrumbs[i];
      p = p.children[j];
      expandNode(o,p,true);
    }
    p.itemDiv.className = p.itemDiv.className + " selected";
    p.itemDiv.id = "selected";
    $(window).load(showRoot);
  }
}

