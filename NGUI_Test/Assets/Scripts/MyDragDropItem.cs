﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDragDropItem : UIDragDropItem {

    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);

        //进行我们处理的代码
        print(surface);
    }
}
