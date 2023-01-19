<script lang="ts">
	import { Modal } from 'svelte-simple-modal';
	import PopupButton from './PopupButton.svelte';
	import type { Entry } from '$lib/ts/entry';

	export let cell: any;
	const data: Entry = cell.data;
</script>

<Modal>
	<PopupButton {data} />
</Modal>
