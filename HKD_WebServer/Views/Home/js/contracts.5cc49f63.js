(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["contracts"],{1681:function(t,e,s){},"2bfd":function(t,e,s){},"7e58":function(t,e,s){},faaa:function(t,e,s){"use strict";s.r(e);var a=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("v-card",{staticClass:"funnyback"},[s("v-card-text",[s("SearchForm",{attrs:{status:"status"}}),t._v("\n    selected - "+t._s(t.selected)+"\n    "),s("p",{staticClass:"subtitle-2 font-italic font-weight-medium"},[t._v("\n      Для просмотра связанных с документом сканов раскройте его по кнопке слева в строке - "),s("v-icon",[t._v("mdi-chevron-down")])],1),s("Table",{attrs:{headers:t.headers,items:t.items,status:t.status,error:t.error,expanded:t.expanded,"show-expand":"","item-key":"idhkd","show-select":""},on:{"update:expanded":function(e){t.expanded=e},"toggle-select-all":function(e){return t.selectItems(e)},"item-selected":function(e){return t.selectItem(e)}},scopedSlots:t._u([{key:"expanded-item",fn:function(e){var a=e.headers,i=e.item;return[s("td",{staticStyle:{padding:"0 0"},attrs:{colspan:a.length}},[s("v-data-table",{staticStyle:{padding:"0 0 0 56px"},attrs:{value:i.select,headers:t.headers_docs,items:i.docs,"show-select":"","hide-default-footer":!0},on:{input:function(t){i.select=t}}})],1)]}}]),model:{value:t.selected,callback:function(e){t.selected=e},expression:"selected"}})],1),s("ActionMenu",{attrs:{selected:t.selected},on:{"update:selected":function(e){t.selected=e}}})],1)},i=[],n=s("2f62"),l=s("702d"),r=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("v-form",{on:{submit:t.search},model:{value:t.valid,callback:function(e){t.valid=e},expression:"valid"}},[s("v-container",[s("v-row",[s("v-col",{attrs:{cols:"6"}},[s("v-combobox",{attrs:{items:t.partners,"item-text":"Name","item-value":"Id",label:"Партнер",multiple:"",hint:"Выберите партнеров для поиска"},model:{value:t.partner,callback:function(e){t.partner=e},expression:"partner"}})],1),s("v-col",{attrs:{cols:"6"}},[s("v-combobox",{attrs:{disabled:0===t.partner.length,items:t.filteredCessions,"item-text":"Name","item-value":"Id",label:0===t.partner.length?"Выберите партнеров":"Цессии",multiple:"","no-data-text":"Не найдено цессий для данных партнеров",hint:"Цессии","persistent-hint":!0},model:{value:t.cession,callback:function(e){t.cession=e},expression:"cession"}})],1)],1),s("v-row",{attrs:{justify:"space-between"}},[s("v-row",[s("v-col",[s("v-btn-toggle",{attrs:{rounded:""},model:{value:t.parameter,callback:function(e){t.parameter=e},expression:"parameter"}},t._l(t.mapParameters,function(e,a){return s("v-btn",{attrs:{value:a}},[t._v("\n              "+t._s(e)+"\n            ")])}),1),s("p",[t._v("! - строгое соответствие,  ? - не строгое соответствие")])],1)],1),s("v-btn-toggle",{attrs:{rounded:""},model:{value:t.scans,callback:function(e){t.scans=e},expression:"scans"}},t._l(t.mapScans,function(e,a){return s("v-btn",{attrs:{value:a}},[t._v("\n          "+t._s(e)+"\n        ")])}),1)],1),s("v-row",[s("v-textarea",{attrs:{disabled:void 0===t.parameter,"auto-grow":!0,clearable:!0,filled:!0,hint:"Значения для поиска","persistent-hint":!0,label:void 0===t.parameter?"Выберите тип параметра":"Введите значения","no-resize":!0,"single-line":!0},on:{keyup:function(e){if(!e.type.indexOf("key")&&t._k(e.keyCode,"down",40,e.key,["Down","ArrowDown"]))return null;t.searchParam+="\n"}},nativeOn:{keyup:function(e){return!e.type.indexOf("key")&&t._k(e.keyCode,"enter",13,e.key,"Enter")?null:(e.preventDefault(),t.search(e))}},model:{value:t.searchParam,callback:function(e){t.searchParam=e},expression:"searchParam"}})],1),s("v-row",[s("div",{staticClass:"flex-grow-1"}),s("v-btn",{staticClass:"mx-2",on:{click:t.clearSearch}},[t._v("\n        Сбросить\n      ")]),s("v-btn",{attrs:{type:"submit",disabled:t.action}},[t._v("\n        Поиск\n      ")])],1)],1),s("FuckDialog",{model:{value:t.dialog,callback:function(e){t.dialog=e},expression:"dialog"}})],1)},o=[],c=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",[s("v-dialog",{attrs:{width:"500"},on:{"click:outside":t.outClick},model:{value:t.dialog_local,callback:function(e){t.dialog_local=e},expression:"dialog_local"}},[s("v-card",[s("v-card-title",{staticClass:"headline grey lighten-2",attrs:{"primary-title":""}},[t._v("\n      Подтвердите действие\n    ")]),s("v-card-text",[t._v("\n      "+t._s(t.textDialog)+"\n    ")]),s("v-divider"),s("v-card-actions",[s("div",{staticClass:"flex-grow-1"}),s("v-btn",{attrs:{color:"primary",text:""},on:{click:t.resetDialog}},[t._v("\n        Ок\n      ")])],1)],1)],1)],1)},h=[];const d=["Вы точно уверены что хотите начать поиск?","Нет, вы как то не очень уверенно говорите что вы уверены.","Ну так что, мы поиск начинаем?","Точно начинаем? ощущение что это мне надо а не вам","Вот щас ваше нажатие выглядело как одолжение","Ты просишь меня начать поиск, но ты делаешь это без уважения","И вот не надо тыкать в кнопку так, будто от этого зависит чья то жизнь","Точно ищем??","Да не зачем так по кнопке долбить!","Да ладно, ладно, сказали искать пошли искать","Так, я забыл, а мы уже ищем?","А вы уверены что мы то что нужно ищем? А то щас что нить найдем, и сами не обрадуемся","Так, я меееедленнно начинаю посик, собираю байты. Ты уже приготовился к результатам?","Да нормальный поиск, не долгий! Нормальный!","Да почти нашли уже!","Нет, я так не могу. Всё, ухожу в отпуск!","Ищите сами, по старинке!!","Я Вам не джин, всякими поисками заниматься"],u=["Вы думаете от меня так легко отделаться?","Это мы уже пробовали","Нет, ну и куда мы теперь пошли? начали искать давайте искать","Так, вот не я это начал!"];function*p(){let t=0;while(1)yield d[t],t=d.length-1===t?0:t+1}let m=p();function*v(){let t=0;while(1)yield u[t],t=u.length-1===t?0:t+1}let g=v();var f={props:["value"],data:()=>({textDialog:"Вы уверены что хотите начать поиск?",dialog_local:!1}),watch:{value(t){console.log("trololo"),this.dialog_local=t}},methods:{async resetDialog(){this.dialog_local=!1,new Promise(t=>{setTimeout(async()=>{this.textDialog=await m.next().value,this.dialog_local=!0,t()},1e3)})},outClick(){this.dialog_local=!1,new Promise(t=>{setTimeout(async()=>{this.textDialog=await g.next().value,this.dialog_local=!0,t()},1e3)})}}},I=f,x=s("2877"),b=s("6544"),S=s.n(b),w=s("8336"),y=s("b0af"),_=s("99d9"),D=s("169a"),V=s("ce7e"),C=Object(x["a"])(I,c,h,!1,null,null,null),k=C.exports;S()(C,{VBtn:w["a"],VCard:y["a"],VCardActions:_["a"],VCardText:_["b"],VCardTitle:_["c"],VDialog:D["a"],VDivider:V["a"]});const T={scans:"Со сканами",allscans:"Все",noscans:"Без сканов"},$={idpristav:"ID пристав",idpkb:"ID ПКБ",idhkd:"ID ХКД",fio:"ФИО!",contractnumber:"Номер договора!",fiolite:"ФИО?",contractnumberlite:"Номер договора?"};var P={components:{FuckDialog:k},props:["status"],data:()=>({dialog:!1,action:!1,mapScans:T,mapParameters:$,valid:void 0,partner:[],cession:[],parameter:"idpristav",searchParam:"",scans:"allscans"}),mounted(){const t={idDebt:12};Promise.all([this.GetPartners(t),this.GetCessions(t)])},computed:{...Object(n["d"])("partners",{statusP:"status",error:"error",partners:"items"}),...Object(n["d"])("cessions",{statusC:"status",error:"error",cessions:"items"}),filteredCessions(){const t=this.partner.map(t=>t.Id);return this.cessions.filter(e=>e.PartnerId in t)}},methods:{...Object(n["b"])("partners",{GetPartners:"GET_ITEMS"}),...Object(n["b"])("cessions",{GetCessions:"GET_ITEMS"}),clearSearch(){this.partner=[],this.cession=[],this.parameter="idpristav",this.searchParam="",this.scans="allscans"},search(){const t={partner:this.partner,cession:this.cession};t[this.parameter]=this.searchParam,t.scans=this.scans,this.$emit("search",t),this.dialog=!0,this.action=!0}}},F=P,O=(s("7e58"),s("604c")),M=O["a"].extend({name:"button-group",provide(){return{btnToggle:this}},computed:{classes(){return O["a"].options.computed.classes.call(this)}},methods:{genData:O["a"].options.methods.genData}}),B=s("a9ad"),E=s("58df"),j=Object(E["a"])(M,B["a"]).extend({name:"v-btn-toggle",props:{rounded:Boolean},computed:{classes(){return{...M.options.computed.classes.call(this),"v-btn-toggle":!0,"v-btn-toggle--rounded":this.rounded,...this.themeClasses}}},methods:{genData(){return this.setTextColor(this.color,{...M.options.methods.genData.call(this)})}}}),z=s("62ad"),A=(s("2bfd"),s("b974")),G=s("8654"),N=s("80d2");const H={...A["b"],offsetY:!0,offsetOverflow:!0,transition:!1};var R=A["a"].extend({name:"v-autocomplete",props:{allowOverflow:{type:Boolean,default:!0},autoSelectFirst:{type:Boolean,default:!1},filter:{type:Function,default:(t,e,s)=>{return s.toLocaleLowerCase().indexOf(e.toLocaleLowerCase())>-1}},hideNoData:Boolean,menuProps:{type:A["a"].options.props.menuProps.type,default:()=>H},noFilter:Boolean,searchInput:{type:String,default:void 0}},data(){return{lazySearch:this.searchInput}},computed:{classes(){return{...A["a"].options.computed.classes.call(this),"v-autocomplete":!0,"v-autocomplete--is-selecting-index":this.selectedIndex>-1}},computedItems(){return this.filteredItems},selectedValues(){return this.selectedItems.map(t=>this.getValue(t))},hasDisplayedItems(){return this.hideSelected?this.filteredItems.some(t=>!this.hasItem(t)):this.filteredItems.length>0},currentRange(){return null==this.selectedItem?0:String(this.getText(this.selectedItem)).length},filteredItems(){return!this.isSearching||this.noFilter||null==this.internalSearch?this.allItems:this.allItems.filter(t=>this.filter(t,String(this.internalSearch),String(this.getText(t))))},internalSearch:{get(){return this.lazySearch},set(t){this.lazySearch=t,this.$emit("update:search-input",t)}},isAnyValueAllowed(){return!1},isDirty(){return this.searchIsDirty||this.selectedItems.length>0},isSearching(){return this.multiple&&this.searchIsDirty||this.searchIsDirty&&this.internalSearch!==this.getText(this.selectedItem)},menuCanShow(){return!!this.isFocused&&(this.hasDisplayedItems||!this.hideNoData)},$_menuProps(){const t=A["a"].options.computed.$_menuProps.call(this);return t.contentClass=`v-autocomplete__content ${t.contentClass||""}`.trim(),{...H,...t}},searchIsDirty(){return null!=this.internalSearch&&""!==this.internalSearch},selectedItem(){return this.multiple?null:this.selectedItems.find(t=>{return this.valueComparator(this.getValue(t),this.getValue(this.internalValue))})},listData(){const t=A["a"].options.computed.listData.call(this);return t.props={...t.props,items:this.virtualizedItems,noFilter:this.noFilter||!this.isSearching||!this.filteredItems.length,searchInput:this.internalSearch},t}},watch:{filteredItems:"onFilteredItemsChanged",internalValue:"setSearch",isFocused(t){t?this.$refs.input&&this.$refs.input.select():this.updateSelf()},isMenuActive(t){!t&&this.hasSlot&&(this.lazySearch=void 0)},items(t,e){e&&e.length||!this.hideNoData||!this.isFocused||this.isMenuActive||!t.length||this.activateMenu()},searchInput(t){this.lazySearch=t},internalSearch:"onInternalSearchChanged",itemText:"updateSelf"},created(){this.setSearch()},methods:{onFilteredItemsChanged(t,e){t!==e&&(this.setMenuIndex(-1),this.$nextTick(()=>{this.internalSearch&&(1===t.length||this.autoSelectFirst)&&(this.$refs.menu.getTiles(),this.setMenuIndex(0))}))},onInternalSearchChanged(){this.updateMenuDimensions()},updateMenuDimensions(){this.isMenuActive&&this.$refs.menu&&this.$refs.menu.updateDimensions()},changeSelectedIndex(t){if(this.searchIsDirty)return;if(![N["v"].backspace,N["v"].left,N["v"].right,N["v"].delete].includes(t))return;const e=this.selectedItems.length-1;if(t===N["v"].left)-1===this.selectedIndex?this.selectedIndex=e:this.selectedIndex--;else if(t===N["v"].right)this.selectedIndex>=e?this.selectedIndex=-1:this.selectedIndex++;else if(-1===this.selectedIndex)return void(this.selectedIndex=e);const s=this.selectedItems[this.selectedIndex];if([N["v"].backspace,N["v"].delete].includes(t)&&!this.getDisabled(s)){const t=this.selectedIndex===e?this.selectedIndex-1:this.selectedItems[this.selectedIndex+1]?this.selectedIndex:-1;-1===t?this.setValue(this.multiple?[]:void 0):this.selectItem(s),this.selectedIndex=t}},clearableCallback(){this.internalSearch=void 0,A["a"].options.methods.clearableCallback.call(this)},genInput(){const t=G["a"].options.methods.genInput.call(this);return t.data=t.data||{},t.data.attrs=t.data.attrs||{},t.data.domProps=t.data.domProps||{},t.data.domProps.value=this.internalSearch,t},genInputSlot(){const t=A["a"].options.methods.genInputSlot.call(this);return t.data.attrs.role="combobox",t},genSelections(){return this.hasSlot||this.multiple?A["a"].options.methods.genSelections.call(this):[]},onClick(){this.isDisabled||(this.selectedIndex>-1?this.selectedIndex=-1:this.onFocus(),this.activateMenu())},onInput(t){if(this.selectedIndex>-1||!t.target)return;const e=t.target,s=e.value;e.value&&this.activateMenu(),this.internalSearch=s,this.badInput=e.validity&&e.validity.badInput},onKeyDown(t){const e=t.keyCode;A["a"].options.methods.onKeyDown.call(this,t),this.changeSelectedIndex(e)},onSpaceDown(t){},onTabDown(t){A["a"].options.methods.onTabDown.call(this,t),this.updateSelf()},onUpDown(){this.activateMenu()},selectItem(t){A["a"].options.methods.selectItem.call(this,t),this.setSearch()},setSelectedItems(){A["a"].options.methods.setSelectedItems.call(this),this.isFocused||this.setSearch()},setSearch(){this.$nextTick(()=>{this.multiple&&this.internalSearch&&this.isMenuActive||(this.internalSearch=!this.selectedItems.length||this.multiple||this.hasSlot?null:this.getText(this.selectedItem))})},updateSelf(){(this.searchIsDirty||this.internalValue)&&(this.valueComparator(this.internalSearch,this.getValue(this.internalValue))||this.setSearch())},hasItem(t){return this.selectedValues.indexOf(this.getValue(t))>-1}}}),K=R.extend({name:"v-combobox",props:{delimiters:{type:Array,default:()=>[]},returnObject:{type:Boolean,default:!0}},data:()=>({editingIndex:-1}),computed:{counterValue(){return this.multiple?this.selectedItems.length:(this.internalSearch||"").toString().length},hasSlot(){return A["a"].options.computed.hasSlot.call(this)||this.multiple},isAnyValueAllowed(){return!0},menuCanShow(){return!!this.isFocused&&(this.hasDisplayedItems||!!this.$slots["no-data"]&&!this.hideNoData)}},methods:{onInternalSearchChanged(t){if(t&&this.multiple&&this.delimiters.length){const e=this.delimiters.find(e=>t.endsWith(e));null!=e&&(this.internalSearch=t.slice(0,t.length-e.length),this.updateTags())}this.updateMenuDimensions()},genChipSelection(t,e){const s=A["a"].options.methods.genChipSelection.call(this,t,e);return this.multiple&&(s.componentOptions.listeners={...s.componentOptions.listeners,dblclick:()=>{this.editingIndex=e,this.internalSearch=this.getText(t),this.selectedIndex=-1}}),s},onChipInput(t){A["a"].options.methods.onChipInput.call(this,t),this.editingIndex=-1},onEnterDown(t){t.preventDefault(),this.$nextTick(()=>{this.getMenuIndex()>-1||this.updateSelf()})},onFilteredItemsChanged(t,e){this.autoSelectFirst&&R.options.methods.onFilteredItemsChanged.call(this,t,e)},onKeyDown(t){const e=t.keyCode;A["a"].options.methods.onKeyDown.call(this,t),this.multiple&&e===N["v"].left&&0===this.$refs.input.selectionStart?this.updateSelf():e===N["v"].enter&&this.onEnterDown(t),this.changeSelectedIndex(e)},onTabDown(t){if(this.multiple&&this.internalSearch&&-1===this.getMenuIndex())return t.preventDefault(),t.stopPropagation(),this.updateTags();R.options.methods.onTabDown.call(this,t)},selectItem(t){this.editingIndex>-1?this.updateEditing():R.options.methods.selectItem.call(this,t)},setSelectedItems(){null==this.internalValue||""===this.internalValue?this.selectedItems=[]:this.selectedItems=this.multiple?this.internalValue:[this.internalValue]},setValue(t){A["a"].options.methods.setValue.call(this,t||this.internalSearch)},updateEditing(){const t=this.internalValue.slice();t[this.editingIndex]=this.internalSearch,this.setValue(t),this.editingIndex=-1},updateCombobox(){const t=Boolean(this.$scopedSlots.selection)||this.hasChips;t&&!this.searchIsDirty||(this.internalSearch!==this.getText(this.internalValue)&&this.setValue(),t&&(this.internalSearch=void 0))},updateSelf(){this.multiple?this.updateTags():this.updateCombobox()},updateTags(){const t=this.getMenuIndex();if(t<0&&!this.searchIsDirty)return;if(this.editingIndex>-1)return this.updateEditing();const e=this.selectedItems.indexOf(this.internalSearch);if(e>-1){const t=this.internalValue.slice();t.splice(e,1),this.setValue(t)}if(t>-1)return this.internalSearch=null;this.selectItem(this.internalSearch),this.internalSearch=null}}}),L=s("a523"),J=s("3206"),U=Object(J["b"])("form").extend({name:"v-form",inheritAttrs:!1,props:{lazyValidation:Boolean,value:Boolean},data:()=>({inputs:[],watchers:[],errorBag:{}}),watch:{errorBag:{handler(t){const e=Object.values(t).includes(!0);this.$emit("input",!e)},deep:!0,immediate:!0}},methods:{watchInput(t){const e=t=>{return t.$watch("hasError",e=>{this.$set(this.errorBag,t._uid,e)},{immediate:!0})},s={_uid:t._uid,valid:()=>{},shouldValidate:()=>{}};return this.lazyValidation?s.shouldValidate=t.$watch("shouldValidate",a=>{a&&(this.errorBag.hasOwnProperty(t._uid)||(s.valid=e(t)))}):s.valid=e(t),s},validate(){return 0===this.inputs.filter(t=>!t.validate(!0)).length},reset(){this.inputs.forEach(t=>t.reset()),this.resetErrorBag()},resetErrorBag(){this.lazyValidation&&setTimeout(()=>{this.errorBag={}},0)},resetValidation(){this.inputs.forEach(t=>t.resetValidation()),this.resetErrorBag()},register(t){this.inputs.push(t),this.watchers.push(this.watchInput(t))},unregister(t){const e=this.inputs.find(e=>e._uid===t._uid);if(!e)return;const s=this.watchers.find(t=>t._uid===e._uid);s&&(s.valid(),s.shouldValidate()),this.watchers=this.watchers.filter(t=>t._uid!==e._uid),this.inputs=this.inputs.filter(t=>t._uid!==e._uid),this.$delete(this.errorBag,e._uid)}},render(t){return t("form",{staticClass:"v-form",attrs:{novalidate:!0,...this.$attrs},on:{submit:t=>this.$emit("submit",t)}},this.$slots.default)}}),W=s("0fd9");s("1681");const Y=Object(E["a"])(G["a"]);var q=Y.extend({name:"v-textarea",props:{autoGrow:Boolean,noResize:Boolean,rowHeight:{type:[Number,String],default:24,validator:t=>!isNaN(parseFloat(t))},rows:{type:[Number,String],default:5,validator:t=>!isNaN(parseInt(t,10))}},computed:{classes(){return{"v-textarea":!0,"v-textarea--auto-grow":this.autoGrow,"v-textarea--no-resize":this.noResizeHandle,...G["a"].options.computed.classes.call(this)}},noResizeHandle(){return this.noResize||this.autoGrow}},watch:{lazyValue(){this.autoGrow&&this.$nextTick(this.calculateInputHeight)},rowHeight(){this.autoGrow&&this.$nextTick(this.calculateInputHeight)}},mounted(){setTimeout(()=>{this.autoGrow&&this.calculateInputHeight()},0)},methods:{calculateInputHeight(){const t=this.$refs.input;if(!t)return;t.style.height="0";const e=t.scrollHeight,s=parseInt(this.rows,10)*parseFloat(this.rowHeight);t.style.height=Math.max(s,e)+"px"},genInput(){const t=G["a"].options.methods.genInput.call(this);return t.tag="textarea",delete t.data.attrs.type,t.data.attrs.rows=this.rows,t},onInput(t){G["a"].options.methods.onInput.call(this,t),this.autoGrow&&this.calculateInputHeight()},onKeyDown(t){this.isFocused&&13===t.keyCode&&t.stopPropagation(),this.$emit("keydown",t)}}}),Q=Object(x["a"])(F,r,o,!1,null,null,null),X=Q.exports;S()(Q,{VBtn:w["a"],VBtnToggle:j,VCol:z["a"],VCombobox:K,VContainer:L["a"],VForm:U,VRow:W["a"],VTextarea:q});var Z=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("v-menu",{attrs:{"offset-x":""},scopedSlots:t._u([{key:"activator",fn:function(e){var a=e.on;return[t.selected.length>0?s("v-btn",t._g({staticStyle:{top:"45%"},attrs:{absolute:"",fixed:"",left:"",color:"warning"}},a),[t._v("\n       "+t._s(t.selected.length)+" "),s("v-icon",[t._v("mdi-printer")])],1):t._e()]}}])},[s("v-card",[s("v-card-title",[t._v("В печать")]),s("v-card-text",[s("v-data-table",{attrs:{headers:t.headers,items:t.selected},scopedSlots:t._u([{key:"item.select",fn:function(e){var s=e.item;return[t._v("\n          "+t._s(s.select.length)+"\n        ")]}}])})],1),s("v-card-actions",[s("div",{staticClass:"flex-grow-1"}),s("v-btn",{on:{click:function(e){t.menu=!1}}},[s("v-icon",[t._v("mdi-cancel")])],1),s("v-btn",{attrs:{color:"primary"},on:{click:function(e){t.menu=!1}}},[s("v-icon",[t._v("mdi-printer")])],1)],1)],1)],1)},tt=[],et={name:"ActionMenu",props:["selected"],components:{},data:()=>({menu:!1,headers:[{text:"Договор",value:"contract_number"},{text:"Должник",value:"fio"},{text:"Количество",value:"select"}]}),mounted(){Promise.all([])},computed:{},methods:{}},st=et,at=s("8fea"),it=s("132d"),nt=s("e449"),lt=Object(x["a"])(st,Z,tt,!1,null,null,null),rt=lt.exports;S()(lt,{VBtn:w["a"],VCard:y["a"],VCardActions:_["a"],VCardText:_["b"],VCardTitle:_["c"],VDataTable:at["a"],VIcon:it["a"],VMenu:nt["a"]});var ot={name:"ContractsView",components:{Table:l["a"],SearchForm:X,ActionMenu:rt},data:()=>({expanded:void 0,selected:[],headers:[{text:"ID ХКД",value:"idhkd",align:"left",sortable:!1},{text:"ID ПКБ",value:"idpkb"},{text:"ID Пристав",value:"idpristav"},{text:"Номер договора",value:"contract_number"},{text:"ФИО должника",value:"fio"},{text:"Цессия",value:"cession"},{text:"Партнер",value:"partner"}],headers_docs:[{text:"ID",value:"id"},{text:"Название",value:"name"}]}),computed:{...Object(n["d"])("contracts",["status","error","items"])},mounted(){const t={idDebt:12};Promise.all([this.GET_ITEM(t)])},methods:{...Object(n["b"])("contracts",["GET_ITEM"]),selectItem({item:t,value:e}){t.select=e?t.docs:[]},selectItems(t){this.items.map(e=>{this.selectItem({item:e,value:t})})},test(t){console.log(t)}}},ct=ot,ht=Object(x["a"])(ct,a,i,!1,null,null,null);e["default"]=ht.exports;S()(ht,{VCard:y["a"],VCardText:_["b"],VDataTable:at["a"],VIcon:it["a"]})}}]);
//# sourceMappingURL=contracts.5cc49f63.js.map